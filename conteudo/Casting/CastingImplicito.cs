using System;

namespace Casting;

public class CastingInplicito
{
    public static void MainImplicito()
    {        
        int someIntNumber = 51;
        long longlNumberCast = someIntNumber;

        Console.WriteLine(longlNumberCast);
    }       
}

/* No exemplo acima, podemos observar uma conversão implícita acontecendo, onde a variável do tipo `long` consegue, perfeitamente e sem perda de informação, acomodar o valor da variável do tipo `int`.

Isso ocorre porque uma variável do tipo `long` **(No máximo 64 bits - 0's ou 1's)** é compatível com uma variável do tipo `int` **(No máximo 32 bits - 0's ou 1's)**:

É possível -> converter -> `Int` -> Para -> `long` */