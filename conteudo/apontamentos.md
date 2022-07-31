# Estruturas de repetição

- while
- do/while
- -for
- foreach
  
> # `while`

Testa uma expressão booleana especificada e, enquanto essa expressão for verdadeira, fará a execução de um bloco de instruções.

Como essa expressão é avaliada antes de cada execução do loop, um loop while é executado zero ou mais vezes. Observe a sintaxe da instrução while a seguir:

```
while (condição)
{
   //bloco de código a ser executado quando a condição for VERDADEIRA    
    comandos;

}
```

## **Exemplo:**

```
var count = 0;
while (count < 10)
{
    Console.WriteLine("count " + count);
    count++;
}
```

No exemplo acima, o while testará a variável count antes de executar seu bloco de instruções. A rotina repetirá esse bloco de instruções até que count fique com valor igual a dez, dessa forma a condição não será mais verdadeira e o loop deixará de ser executado.

> # `do/while`

A instrução de repetição do/while fará primeiro a execução de um bloco de instruções para depois avaliar a expressão booleana especificada, e quando essa expressão for verdadeira, voltará ao início do bloco.

Um loop do/while sempre é executado ao menos uma vez, por exemplo:

```
var count = 0;
do
{
    Console.WriteLine("count " + count);
    count++;
}
while (count < 10);
```
Note que, no exemplo anterior, o do/while testará a variável count após executar a primeira vez seu bloco de instruções. A rotina repetirá esse bloco de instruções até que count fique com valor igual a dez, dessa forma a condição não será mais verdadeira, e o loop deixará de ser executado.

# Anota aí ✏️:
A instrução While testa a variável antes de executar o bloco de instruções. Já a instruçãodo/while executa o bloco de instruções antes de avaliar a variável proposta.

> # `for`

A instrução de repetição for é composta por três expressões separadas por ponto e vírgula (;). Observe a sintaxe a seguir:

```
for (inicialização; condição; incremento)
{
    //comandos;
}
```

- A primeira expressão é a de inicialização. As variáveis inicializadas no cabeçalho for ficam disponíveis somente no escopo do loop, ou seja, somente dentro do código de iteração do loop.

- A segunda expressão é a condição para a execução da iteração do laço. Na primeira execução do loop, a condição é testada após a inicialização, nas demais iterações a condição é testada após o incremento.

- A terceira expressão é responsável por fazer a iteração da variável. Essa expressão é executada ao final do bloco de instruções e antes da verificação da condição do loop

## **Exemplo:**

```
for (int count = 0; count < 3; count++)
{
    Console.WriteLine("numero: " + count);
}
```
No exemplo acima, a variável count é inicializada com valor 0, e o bloco de instrução do for será executado com a condição de count ser menor que 3. Em cada iteração do loop ainda haverá o incremento da variável count.

> # `foreach`

Utilizamos o foreach para percorrer, um a um, os elementos de uma array ou coleção (collection).

```
foreach (tipo elemento in coleção)
{
    //comandos;
}
```

Na declaração do foreach, temos a inicialização de uma variável do mesmo tipo da coleção, o operador in, a coleção que o laço percorrerá e o bloco de instruções a ser executado. A cada incremento do laço, um elemento da coleção será atribuído ao elemento inicalizado na declaração e então o bloco de instruções será executado.

## **Exemplo:**

```
string[] names = new string[] { "Hulk", "Thor", "Loki" };
foreach (var name in names)
{
    Console.WriteLine(name);
}
```

No exemplo acima, o bloco de instruções do laço de repetição foreach será executado para cada name contido no array names.

A leitura desse código é algo como: “execute o laço para cada name existente no array names“

> # Instruções de uma única linha

No C#, um bloco de instrução é sempre escrito entre chaves {} para delimitar seu contexto. Porém, o uso das chaves não é obrigatório para definir uma instrução de uma linha como ocorre em: `for`, `foreach` e `while`.

# **Exemplo:**

```
for (int count = 0; count < 10; count++)
    Console.WriteLine(count);
```

```
int[] numbers = new int[] { 1, 2, 3, 4 };
var sum = 0;
foreach (var number in numbers)
    sum += number;
```

```
var isClosed = false;
while (!isClosed)
    isClosed = CloseConnection();
```

> # Instrução `break`

A instrução break, como o próprio nome já diz, é utilizada para interromper a execução de um laço de repetição (`for`, `foreach`, `do\while` e `while`).

# **Exemplo:**

```
string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
string[] students = new string[] { "Ellie", "Joel", "Abby" };
foreach (var teacher in teachers)
{
    Console.WriteLine("Professor: " + teacher + ". Estudante:");
    foreach (var student in students)
    {               
        if (teacher == student)
            break;
        Console.WriteLine(student);
    }
}  
```

**Execute o laço para cada teacher existente no array teachers**

Quando temos dois laços foreach aninhados, a instrução break interrompe apenas o loop mais interno que a contém. Portanto, com base no exemplo acima, quando a variável teacher for igual a student o código interromperá somente a execução do laço da variável students. A linha Console.WriteLine(student); não será executada e a execução continuará percorrendo o laço mais externo, da variável teachers.

> # Instrução `continue`

A instrução continue é utilizada para saltar uma iteração de um laço de repetição (`for`, `foreach`, `do\while` e `while`)

# **Exemplo:**

Vamos avaliar um código de contagem de votos válidos:

O exemplo considera números menores que três como voto válido.

```
int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2};
var count = 0;
foreach (var vote in votes)
{                    
    if (vote > 3)
        continue;
    count++;    
}  
Console.WriteLine(count + ' votos válidos');
```

O laço foreach percorrerá todos os itens do array verificando se o valor do mesmo é maior que três. Se for, fará uso da instrução continue para saltar a iteração do laço. Dessa forma a variável count só será incrementada para votos válidos.

