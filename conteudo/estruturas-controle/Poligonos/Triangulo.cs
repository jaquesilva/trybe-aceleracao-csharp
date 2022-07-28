namespace Poligonos;
public static class Triangulo
{
  public static string ClassificarTriangulo(double ladoA, double ladoB, double ladoC)
  {
    var nomeTriangulo = string.Empty;

    if(ladoA == ladoB && ladoA == ladoC)
    {
      nomeTriangulo = "Triângulo Equilátero";
    } 
    else if((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
    {
      nomeTriangulo = "Triângulo Isóscele";
    }
    else
    {
      nomeTriangulo = "Triângulo Escaleno";
    }
    return nomeTriangulo;
  }
}