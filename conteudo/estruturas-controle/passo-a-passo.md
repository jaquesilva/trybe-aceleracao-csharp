## Para criar um projeto classlib

mkdir estruturas-controle 

cd estruturas-controle

dotnet new sln // cria o arquivo de solução

dotnet new classlib -o Poligonos // Poligonos é o nome do projeto/diretório que será criado

dotnet sln estruturas-controle.sln add Poligonos/Poligonos.csproj // Adiciona o projeto "Poligonos" na solução

## Para criar o projeto de teste usando xUnit

/estruturas-controle

dotnet new xunit -n Poligonos.Test

dotnet sln estruturas-controle.sln add Poligonos.Test/Poligonos.Test.csproj // Adicona o projeto "Poligonos.test" na solução

dotnet add Poligonos.Test/Poligonos.Test.csproj reference Poligonos/Poligonos.csproj // Adiciona a referência do projeto "Poligonos" que será testado

dotnet add Poligonos.Test/Poligonos.Test.csproj package FluentAssertions // Adiciona o pacote FluentAssertions no projeto "Poligonos.Test"

