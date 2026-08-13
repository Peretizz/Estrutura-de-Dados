string palavra = "";

Console.WriteLine("Digite uma palavra:");
palavra = Console.ReadLine();

string[] letras = new string[palavra.Length];
string[] letras2 = new string[palavra.Length];

for (int i = 0; i < palavra.Length; i++)
{
    letras[i] = palavra[i].ToString();
}

for (int i = palavra.Length - 1; i >= 0; i--)
{
    letras2[i] = palavra[palavra.Length - 1 - i].ToString();
}

bool palindromo = true;

for (int i = 0; i < palavra.Length; i++)
{
    if (letras[i] != letras2[i])
    {
        palindromo = false;
        break;
    }
}

if (palindromo)
{
    Console.WriteLine("A palavra é um palíndromo");
}
else
{
    Console.WriteLine("A palavra não é um palíndromo");
}