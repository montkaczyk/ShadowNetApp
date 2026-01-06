namespace ShadowNetApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            this.labelThreatList = new System.Windows.Forms.Label();
            this.listBoxMails = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelThreatLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThreatList
            // 
            this.labelThreatList.AutoSize = true;
            this.labelThreatList.Location = new System.Drawing.Point(12, 9);
            this.labelThreatList.Name = "labelThreatList";
            this.labelThreatList.Size = new System.Drawing.Size(194, 16);
            this.labelThreatList.TabIndex = 0;
            this.labelThreatList.Text = "Lista podejrzanych wiadomości";
            // 
            // listBoxMails
            // 
            this.listBoxMails.FormattingEnabled = true;
            this.listBoxMails.ItemHeight = 16;
            this.listBoxMails.Location = new System.Drawing.Point(13, 29);
            this.listBoxMails.Name = "listBoxMails";
            this.listBoxMails.Size = new System.Drawing.Size(723, 148);
            this.listBoxMails.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Szczegóły";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelThreatLevel
            // 
            this.labelThreatLevel.AutoSize = true;
            this.labelThreatLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelThreatLevel.ForeColor = System.Drawing.Color.Gray;
            this.labelThreatLevel.Location = new System.Drawing.Point(12, 196);
            this.labelThreatLevel.Name = "labelThreatLevel";
            this.labelThreatLevel.Size = new System.Drawing.Size(164, 17);
            this.labelThreatLevel.TabIndex = 3;
            this.labelThreatLevel.Text = "Poziom zagrożenia: brak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelThreatLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMails);
            this.Controls.Add(this.labelThreatList);
            this.Name = "Form1";
            this.Text = "Agent 07.5 – Panel Operacyjny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThreatList;
        private System.Windows.Forms.ListBox listBoxMails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelThreatLevel;
    }
}
