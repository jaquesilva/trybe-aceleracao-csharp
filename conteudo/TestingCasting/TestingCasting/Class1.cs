namespace TestingCasting;
public class Class1
{
  // public string someString = "oi";
  
  // ============================================

  // E se quiséssemos testar a conversão de uma variável do tipo int em um tipo double?
  // public int intEntry = 42;
  // public double doubleResponse;

  // public void Transform()
  // {
  //   floatResponse = (double) intEntry;
  // }

  // ============================================

  // Vamos testar a conversão de string para int!
  
  public string strEntry = "42";
  public int intResponse;

  public void DoConversion()
  {
      if(strEntry is string)
      {
          intResponse = Convert.ToInt32(strEntry);
      }
  }
}
