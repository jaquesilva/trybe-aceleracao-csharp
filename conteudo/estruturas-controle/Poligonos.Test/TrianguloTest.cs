using Xunit;
using FluentAssertions;
using Poligonos; // nome do namespace do projeto a ser testado

namespace Poligonos.Test;

public class TrianguloTest
{
    [Theory(DisplayName = "Deve classificar um trinângulo")]
    [InlineData(2,2,2, "Triângulo Equilátero")]
    [InlineData(5,6,6, "Triângulo Isóscele")]
    [InlineData(6,2,6, "Triângulo Isóscele")]
    [InlineData(6,6,2, "Triângulo Isóscele")]
    [InlineData(1,2,3, "Triângulo Escaleno")]

    public void TestClassificarTriangulo(double ladoA, double ladoB, double ladoC, string nomeEsperado)
    {
        var nomeTriangulo = Triangulo.ClassificarTriangulo(ladoA, ladoB, ladoC);
        nomeTriangulo.Should().Be(nomeEsperado);
    }
}