using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando o dicionário com os produtos e suas áreas
        Dictionary<string, string> produtos =
            new Dictionary<string, string>
            {
                { "5900000000000", "A1" },
                { "5901111111111", "B5" },
                { "5902222222222", "C9" }
            };

        // Adicionando um produto em tempo de execução
        produtos["5903333333333"] = "D7";

        // Adicionando usando o método Add()
        // Tratando possível erro de chave duplicada
        try
        {
            produtos.Add("5904444444444", "A3");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("A entrada já existe.");
        }

        // Percorrendo todos os produtos
        Console.WriteLine("Todos os produtos:");

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            foreach (KeyValuePair<string, string> produto in produtos)
            {
                Console.WriteLine($" - {produto.Key}: {produto.Value}");
            }
        }

        // Busca por código de barras
        Console.WriteLine();
        Console.Write("Digite o código de barras: ");
        string codigoBarras = Console.ReadLine();

        if (produtos.TryGetValue(codigoBarras, out string area))
        {
            Console.WriteLine($"O produto está localizado na área {area}.");
        }
        else
        {
            Console.WriteLine("O produto não existe.");
        }
    }
}
