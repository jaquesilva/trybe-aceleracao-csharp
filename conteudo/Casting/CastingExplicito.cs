using System;

namespace Casting;

public class CastingExplicito
{
    /* Não é possível -> converter -> `long` -> Para -> `Int` , pois o espaço na memória que o `long` necessita são 64 bits, e o `int` tem apenas 32 bits

    (int)
    O mais simples é adicionar a sintaxe (int) - linha 10, para indicar que queremos transformar, mesmo que ocorra perda de informação!

    Cuidado ao usar apenas o cast (int), pois se você perder informação no processo o C# não irá te avisar disso! */

    // public static void Main()
    // {        
    //     long someLongNumber = 516144564564654;
    //     int intNumber = (int) someLongNumber;

    //     Console.WriteLine(intNumber);
    // }  


    /* Outra opção

    Convert.ToInt32()

    Utilizar o Convert acompanhada do .ToInt32, indicando assim que desejamos realizar uma conversão explícita e, com o .ToInt32, indicamos o tipo para o qual desejamos que a variável seja convertida */

    //  public static void ConvertWithToInt32Wrong()
    // {        
    //     long someLongNumber = 516144564564654;
    //     int intNumber = Convert.ToInt32(someLongNumber);

    //     Console.WriteLine(intNumber);
    // }  

    /* Nesse caso, o Convert.ToInt32 vai nos avisar de que o número 516144564564654 não cabe em uma variável int, com o seguinte erro:

    Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.
    at System.Convert.ThrowInt32OverflowException()
    at System.Convert.ToInt32(Int64 value)
    at Program.Main() in /Users/rahelund/C#/teste cod/Program.cs:line 6 

    Porém, se for possível converter o número, ele vai funcionar sem problemas. */

    // public static void ConvertWithToInt32Right()
    // {        
    //     long someLongNumber = 42;
    //     int intNumber = Convert.ToInt32(someLongNumber);

    //     Console.WriteLine(intNumber);
    // }    

    // Podemos converter uma string para um número inteiro

    // public static void ConvertStringToInt()
    // {        
    //     string someString = "42";
    //     int convertInt = Convert.ToInt32(someString);

    //     Console.WriteLine(convertInt);
    // }  

    /* Mas como saberemos se ele realmente converteu a string em um int? 

    Resposta: Utilizando o operador is, que em Inglês significa “é”. Esse operador é utilizado para realizar comparações entre variáveis e tipos. */

    //  public static void IsString()
    // {        
    //     string someString = "2022";
    //     Console.WriteLine(someString is string);

    //     int convertInt = Convert.ToInt32(someString);
    //     Console.WriteLine(convertInt is int);
    // }

    // Com isso, podemos verificar o tipo de uma variável e, então, tomar decisões sobre como lidar com ela

     public static void Main()
    {        
        string someString = "20";
        int number = 0;
        
        if(someString is string)
        {
            number = Convert.ToInt32(someString);
            Console.WriteLine(number);
        }
    }
};


