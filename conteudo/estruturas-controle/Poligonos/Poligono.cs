namespace Poligonos;

public static class Poligonos
{
  public static string ClassificarPoligono(int numeroLados)
  {
    var nomePoligono = string.Empty;

    switch (numeroLados)
    {
      case < 3:
        nomePoligono = "Não é um polígono";
        break;
      case 3:
        nomePoligono = "Triângulo";
        break;
      case 4:
        nomePoligono = "Quadrado";
        break;
      case 5:
        nomePoligono = "Pentágono";
        break;
      default:
        nomePoligono = "Polígono não identificado";
        break;
    }
    return nomePoligono;
  }
}
