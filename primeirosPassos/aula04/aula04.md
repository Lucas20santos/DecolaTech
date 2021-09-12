# Conhecendo o Csharp

## Tipos de variáveis

Variáveis de tipso de valor contêm diretamente seus dados

As variáveis têm sua própria cópia dos daods e não é possǘiel que as operações afetem outra variável
(exceto no caso das variáveis de parâmetros ref e out)

Numéricos: sbyte, short, int, long, byte, ushort, uint, ulong

Caracteres Unicode: char

Pontos flutuantes: float, double decimal

Booleano: bool

enum, struct e tipos nullable (Exemplo int?)

## Tipos de referência

Variáveis de tipos de referência armazenam referências a seus dados

É possível que duas variáveis façam referência ao mesmo objeto e, portanto, que operações em uma variável afetem o objeto referenciado pela outra variáviel.

Tipos classes: class, object, string

Tipos Arrays: int[], int[,], etc...

**interface**, **delegate**

## Instruções

Ações de um programa são expressas usando instruções

- Declaração de variáveis e constantes locais
- if
- Switch
- while
- do
- for
- foreach
- break
- continue
- return
- throw
- try... catch... finally
- using


## Arrays

Um **array** e uma estrutura de dados que contem um numero X de **elementos**, todos do mesmo **tipo**, que sao acessados atraves de **indices** compuados.

Arrays sao tipos de referencia e a declaraçao de uma variavel array simplesmente reserva espaço para uma referencia de uma instancia de array.

Ao criar um array e especificado o **tamanho** da nova instancia, que e fixo durante todo o tempo de vida da instancia

Os indices dos elementos de um array variam de **0** a **comprimento do array - 1**

### Arrays Unidimensional

```.
int[] a = new int[10]; // declarando o array de inteiros de tamanho 10, os indices variam de 0 a 9

for(int i = 0; i < a.Length; i++)
{
	a[i] = i * i;
	Console.WriteLine($"a[{i}] = {a[i]}");
}

```

### Arrays MultiDimensional

```.
int[,] a2 = new int[10, 5]
int[,,] a3 = new int[10, 5, 2]


```




