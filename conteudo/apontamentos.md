# casting = transformação

**C# é uma linguagem tipada em tempo de compilação, ou seja, as variáveis possuem tipos específicos logo no momento em que o código é compilado, possuindo assim suas próprias propriedades estáticas.**

Entretanto, muitas vezes, em um algoritmo precisamos realizar operações entre variáveis de tipos diferentes. Por exemplo:


Comparar variáveis de tipos diferentes:

`3 (int) >= 2.5 (float)` ?

Realizar operações matemáticas entre variáveis

`5.3 (float) - 10.333333333 (decimal)`

Essas operações podem até gerar, como produto, uma variável de tipo diferente. Para resolver essa situação, vamos ver o que é Casting, conhecida em C# por transformação.

A transformação de uma variável de determinado tipo em outro pode ocorrer de diferentes formas. Essas transformações são chamadas de:

* Cast Implícito: como o próprio nome sugere, ocorre quando não declaramos no código que essa transformação deve ocorrer, ou seja, a deixamos implícita no código.

* Cast Explícito: quando precisamos escrever a transformação e como ela irá ocorrer via código.


