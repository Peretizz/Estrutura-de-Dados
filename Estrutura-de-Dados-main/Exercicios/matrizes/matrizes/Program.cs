/* Vetores Multi-Dimensionais */

// Vetor Bi-Dimensional  [Linhas,Colunas]
int[,] numbersBi = new int[5,2];

// Vetor Tri-Dimensional [Linhas,Colunas,Profundidade]
int[,,] numbersTri = new int[5,2,3];

//Podemos combinar a declaração com a incialização
int[,] newNumbersBi = new int[,] {
    {9, 5, -9}, 
    {-11, 4, 0}, 
    {6, 115, 3}, 
    {-12, -9, 71}, 
    {1, -6, -1}
};

// Percorrendo a Matriz. Exemplo de repetição for encadeada
// Nested/Chained for
for (int i = 0; i < newNumbersBi.GetLength(0); i++)
{
    for (int j = 0; j < newNumbersBi.GetLength(1); j++)
    {
        Console.WriteLine($"{newNumbersBi[i,j]}");
    }
    Console.WriteLine("");
}

// Jagged Arrays ou Arréi de Jegues
// Vetor de Vetores 

int[][] jaggedNumbers = new int[4][];

// Atribuindo valores 
jaggedNumbers[0] = new int[] { 9, 5, -9 };
jaggedNumbers[1] = new int[] { 0, -3, 12, 51, -3 };
jaggedNumbers[3] = new int[] { 51 }; 


// Declaração com inicialização
int[][] newJaggedNumbers2 = new int[][]
{
    new int[] { 0, 1 , 2 },
    new int[] { 3, 4, 5, 6 },
    null,
    new int[] { 7, 8, 9, 10 },
};

// Para acessar uma posição específica 
int v = jaggedNumbers[1][2];
jaggedNumbers[1][2] = 22;

Console.WriteLine("v = " + v);
Console.WriteLine("JaggedNumbers[1][2] = " + jaggedNumbers[1][2]);