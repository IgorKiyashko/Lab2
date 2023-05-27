FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /tests

# Copy everything
COPY . ./

RUN dotnet restore
RUN dotnet build

CMD ["dotnet", "test", "--no-restore"]