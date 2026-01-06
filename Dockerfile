# escape=`

FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2022 AS build
WORKDIR /src
COPY . .
RUN msbuild ShadowNetApp.sln /p:Configuration=Release

FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2022
WORKDIR /app
COPY --from=build /src/bin/Release/ .
ENTRYPOINT ["ShadowNetApp.exe"]
