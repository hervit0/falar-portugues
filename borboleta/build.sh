if [ ! -e "paket.lock" ]
then
    exec mono .paket/paket.exe install
fi
dotnet restore src/Borboleta
dotnet build src/Borboleta

dotnet restore tests/Borboleta.Tests
dotnet build tests/Borboleta.Tests
dotnet test tests/Borboleta.Tests
