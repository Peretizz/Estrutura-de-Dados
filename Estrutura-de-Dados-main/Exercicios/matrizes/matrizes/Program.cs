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
        Console.WriteLine($"Elemento [{i},{j}] = {newNumbersBi[i,j]}");
    }
}