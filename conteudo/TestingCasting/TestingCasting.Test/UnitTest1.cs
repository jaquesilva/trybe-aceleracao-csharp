using Xunit;
using FluentAssertions;

namespace TestingCasting.Test;

public class UnitTest1
{
    // [Fact]
    // public void TestVariableCreation()
    // {
    //     Class1 instance = new();

    //     var response = instance.someString is string;
    //     response.Should().Be(true);
    // }

    // public void TestVariableConversion()
    // {
    //     Class1 instance = new();

    //     instance.intEntry.Should().Be(42); // primeiro vamos garantir que a variável intEntry está com o valor 42 e é do tipo int
    //     var intTypeCheck = instance.intEntry is int;
    //     intTypeCheck.Should().Be(true);

    //     instance.Transform();

    //     instance.doubleResponse.Should().Be(42.0); // Caso verdadeiro, chamamos a conversão com instance.Convert(); e tentamos garantir que a variável doubleResponse tenha o valor convertido 42.0 e seja do tipo que queremos: double
    //     var floatTypeCheck = instance.doubleResponse is double;
    //     floatTypeCheck.Should().Be(true);
    // }

    // public void TestVariableConversion()
    // {
    //     Class1 instance = new();

    //     instance.strEntry.Should().Be("42"); // Verifica se o valor da variável "strEntry" é "42"
    //     var strTypeCheck = instance.strEntry is string; // Verifica se é do tipo string
    //     strTypeCheck.Should().Be(true);

    //     instance.DoConversion(); // Faz a conversão

    //     instance.intResponse.Should().Be(42); // Verifica se o "intResponse" é o 42
    //     var intTypeCheck = instance.intResponse is int; // Mas dessa vez verifica se ele é inteiro
    //     intTypeCheck.Should().Be(true);
    // }

    // E, com o comportamento similar ao código anterior, vamos verificar o tipo e o valor das nossas variáveis antes e depois da conversão

    // Usando o FluentAssertions

    [Theory(DisplayName = "Deve converter string para inteiro")] // Uma teoria, e para testar teoria, precisamos de diversos casos
    [InlineData("1", 1)]
    [InlineData("100", 100)]
    [InlineData("-50", -50 )]
    public void TestVariableConversion(string entry, int expected) // entry é o primeiro parâmetro do InLineData - expected é o segundo parâmetro do InLineData
    {
        Class1 instance = new();

        instance.strEntry = entry; 
        var strTypeCheck = instance.strEntry is string; 
        strTypeCheck.Should().Be(true);

        instance.DoConversion(); 

        instance.intResponse.Should().Be(expected); 
        var intTypeCheck = instance.intResponse is int; 
        intTypeCheck.Should().Be(true);
    }

    // Obs: Para cada InLineData é executado 1 teste, então, no caso acima serão 3 execuções.
}   
