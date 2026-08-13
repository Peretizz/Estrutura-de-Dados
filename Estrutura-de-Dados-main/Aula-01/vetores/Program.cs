using System.Runtime.Serialization;

Console.WriteLine("Hello, World!");

//comentário de uma linha

/*
Comentário de
múltiplas linhas
*/

//Alguns tipos de dados
int number = 10;
string name = "Nicolas Pereti";
double quantity = 0.0;
bool hasMoney = true;
char letter = 'A';

// Constantes
const int DAYS_IN_WEEK = 7;

letter = 'B';

Console.WriteLine ("Informe seu nome:");
name = Console.ReadLine ();

Console.WriteLine("Seja bem-vindo " + name);

//Enumeradores
//enum Language { PT, EN, ES }

//Concatenando strings

string firstName = "Nicolas", lastname = "";
lastname = "Pereti";

string fullName = firstName + " " + lastname;
Console.WriteLine(fullName);

string middleName = "Negrao";

//Interpolação de string
string message = $"Nome Completo: {firstName} {middleName} {lastname}";
Console.WriteLine(message);

/*
VETORES UNI-DIMENSIONAIS
Sintaxe: type[] name;
*/
int[] numbers;

//Inicializando o vetor
numbers = new int[5];

// Atribuindo valores ao vetor
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

//É possível declarar o vetor e já definir e atribuir

int[] numbers2 = new int[] { 100, 200, 300 };
int[] numbers3 = { 1000, 2000, 3000, 4000 };

//Percorrendo o vetor e adicionando valores dinamicamente
Console.WriteLine("Iniciando com vetores");

Console.WriteLine("Informe o tamanho do vetor:");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[size];
int total = 0; //acumulador
int counter = 0; //contador

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine("Informe o valor para a posição [" + i + "]:");
    myArray[i] = Convert.ToInt32(Console.ReadLine());

    total += myArray[i];
    counter++;
}

Console.WriteLine("Contagem = " + counter);