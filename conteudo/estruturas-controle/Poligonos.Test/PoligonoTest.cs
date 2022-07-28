using Xunit;
using FluentAssertions;
using Poligonos; // nome do namespace do projeto a ser testado

namespace Poligonos.Test;

public class PoligonoTest
{
    [Theory(DisplayName = "Deve classificar um polígono")]
    [InlineData(2, "Não é um polígono")]
    [InlineData(3, "Triângulo")]
    [InlineData(4, "Quadrado")]
    [InlineData(5, "Pentágono")]
    [InlineData(6, "Polígono não identificado")]

    public void TestClassificarPoligono(int numeroLados, string nomeEsperado)
    {
        var nomePoligono = Poligonos.ClassificarPoligono(numeroLados);
        nomePoligono.Should().Be(nomeEsperado);
    }
}