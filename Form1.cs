using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShadowNetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxMails.Items.Add("Podejrzana wiadomość od: hr@tajna-armia.pl");
            listBoxMails.Items.Add("Wiadomość z załącznikiem: fake_invoice.exe");
            listBoxMails.Items.Add("Hej, co tam?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxMails.SelectedItem != null)
            {
                string selectedMessage = listBoxMails.SelectedItem.ToString();
                MessageBox.Show($"Szczegóły wiadomości:\n\n{selectedMessage}", "Szczegóły", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Wywołaj analizę zagrożenia
                string level = AnalyzeThreat(selectedMessage);
                labelThreatLevel.Text = $"Poziom zagrożenia: {level}";

                // Zmieniaj kolor na podstawie poziomu
                switch (level)
                {
                    case "Wysokie":
                        labelThreatLevel.ForeColor = Color.Red;
                        break;
                    case "Średnie":
                        labelThreatLevel.ForeColor = Color.Orange;
                        break;
                    default:
                        labelThreatLevel.ForeColor = Color.Green;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wybierz wiadomość z listy przed wyświetleniem szczegółów.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string AnalyzeThreat(string message)
        {
            if (message.Contains("exe") || message.Contains("hr@")) return "Wysokie";
            if (message.Contains("załącznik")) return "Średnie";
            return "Niskie";
        }
    }
}
