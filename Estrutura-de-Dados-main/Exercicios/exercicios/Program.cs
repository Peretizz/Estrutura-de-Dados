int[] pares = new int[10];
int[] impares = new int[10];

int contPar = 0;
int contImpar = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Informe um valor:");
    int valor = Convert.ToInt32(Console.ReadLine());

    if (valor % 2 == 0)
    {
        pares[contPar] = valor;
        contPar++;
    }
    else
    {
        impares[contImpar] = valor;
        contImpar++;
    }
}

Console.WriteLine("Pares:");
for (int i = 0; i < contPar; i++)
{
    Console.WriteLine(pares[i]);
}

Console.WriteLine("Ímpares:");
for (int i = 0; i < contImpar; i++)
{
    Console.WriteLine(impares[i]);
}