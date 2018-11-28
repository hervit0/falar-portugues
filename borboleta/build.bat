IF NOT EXIST paket.lock (
    START /WAIT .paket/paket.exe install
)
dotnet restore src/Borboleta
dotnet build src/Borboleta

dotnet restore tests/Borboleta.Tests
dotnet build tests/Borboleta.Tests
dotnet test tests/Borboleta.Tests
