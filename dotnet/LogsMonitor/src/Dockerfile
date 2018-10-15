FROM microsoft/dotnet:2.1-sdk AS builder
WORKDIR /app

COPY . ./
RUN dotnet build -c Release
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY --from=builder /app/LogsMonitor.Host/out .
ENTRYPOINT ["dotnet", "LogsMonitor.Host.dll"]