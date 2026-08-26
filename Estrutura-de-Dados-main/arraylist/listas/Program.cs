using System.Collections;
using System.Globalization;
// ArrayLists

ArrayList arrayList = new ArrayList ();

// Adicionando itens à lista
arrayList.Add(5);

//Adicionando quantias de itens à lista
arrayList.AddRange(new int[] { 1, 2, 3 });

//Insere o vcalor 7.8 na posição 3 da lista
arrayList.Insert(3, 7.8);

//Percorrendo itens da lista de forma genérica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}

// listas genericas
List<double> numbers = new List<double>();

Console.WriteLine("Digite sair para encerrar. ");

bool run = true;

do{
    Console.WriteLine("Digite um número: ");
    string numberStr = Console.ReadLine();

    if (numberStr.Equals("sair"))
    {
        run = false;
        Console.WriteLine("Programa encerrado.");
        break;
    }
    else
    {
        if(!double.TryParse(numberStr, System.Globalization.NumberStyles.Float, new NumberFormatInfo(), out double number))
        {
            Console.WriteLine("Você não digitou um número.");
            continue;
        }
        
        numbers.Add(number);
        Console.WriteLine("A média dos valores informados é: " + numbers.Average());
    }
} while (run);