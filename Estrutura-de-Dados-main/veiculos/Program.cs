using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando o dicionário com os automóveis
        Dictionary<string, Dictionary<string, string>> automoveis =
            new Dictionary<string, Dictionary<string, string>>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("SISTEMA DE CONTROLE DE AUTOMÓVEIS");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar automóvel");
            Console.WriteLine("2 - Buscar automóvel pela placa");
            Console.WriteLine("3 - Listar todos os automóveis");
            Console.WriteLine("4 - Buscar automóveis por marca");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();

            Console.Write("Digite uma opção: ");
            string opcao = Console.ReadLine();

            // Cadastrar automóvel
            if (opcao == "1")
            {
                Console.WriteLine();
                Console.WriteLine("CADASTRO DE AUTOMÓVEL");

                Console.Write("Digite a placa: ");
                string placa = Console.ReadLine();

                if (automoveis.ContainsKey(placa))
                {
                    Console.WriteLine("Já existe um automóvel cadastrado com essa placa.");
                }
                else
                {
                    Console.Write("Digite a marca: ");
                    string marca = Console.ReadLine();

                    Console.Write("Digite o modelo: ");
                    string modelo = Console.ReadLine();

                    Console.Write("Digite o ano: ");
                    string ano = Console.ReadLine();

                    Console.Write("Digite a cor: ");
                    string cor = Console.ReadLine();

                    Console.Write("Digite o valor: ");
                    string valor = Console.ReadLine();

                    automoveis.Add(placa, new Dictionary<string, string>
                    {
                        { "Marca", marca },
                        { "Modelo", modelo },
                        { "Ano", ano },
                        { "Cor", cor },
                        { "Valor", valor }
                    });

                    Console.WriteLine("Automóvel cadastrado com sucesso.");
                }
            }

            // Buscar automóvel pela placa
            else if (opcao == "2")
            {
                Console.WriteLine();
                Console.Write("Digite a placa: ");
                string placa = Console.ReadLine();

                if (automoveis.TryGetValue(placa, out Dictionary<string, string> automovel))
                {
                    Console.WriteLine();
                    Console.WriteLine("Automóvel encontrado:");
                    Console.WriteLine($"Placa: {placa}");
                    Console.WriteLine($"Marca: {automovel["Marca"]}");
                    Console.WriteLine($"Modelo: {automovel["Modelo"]}");
                    Console.WriteLine($"Ano: {automovel["Ano"]}");
                    Console.WriteLine($"Cor: {automovel["Cor"]}");
                    Console.WriteLine($"Valor: R$ {automovel["Valor"]}");
                }
                else
                {
                    Console.WriteLine("O automóvel não existe.");
                }
            }

            // Listar todos os automóveis
            else if (opcao == "3")
            {
                Console.WriteLine();
                Console.WriteLine("TODOS OS AUTOMÓVEIS:");

                if (automoveis.Count == 0)
                {
                    Console.WriteLine("Nenhum automóvel cadastrado.");
                }
                else
                {
                    foreach (KeyValuePair<string, Dictionary<string, string>> automovel in automoveis)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Placa: {automovel.Key}");
                        Console.WriteLine($"Marca: {automovel.Value["Marca"]}");
                        Console.WriteLine($"Modelo: {automovel.Value["Modelo"]}");
                        Console.WriteLine($"Ano: {automovel.Value["Ano"]}");
                        Console.WriteLine($"Cor: {automovel.Value["Cor"]}");
                        Console.WriteLine($"Valor: R$ {automovel.Value["Valor"]}");
                    }
                }
            }

            // Buscar automóveis por marca
            else if (opcao == "4")
            {
                Console.WriteLine();
                Console.Write("Digite a marca: ");
                string marcaBusca = Console.ReadLine();

                bool encontrado = false;

                foreach (KeyValuePair<string, Dictionary<string, string>> automovel in automoveis)
                {
                    if (automovel.Value["Marca"].ToLower() == marcaBusca.ToLower())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Placa: {automovel.Key}");
                        Console.WriteLine($"Marca: {automovel.Value["Marca"]}");
                        Console.WriteLine($"Modelo: {automovel.Value["Modelo"]}");
                        Console.WriteLine($"Ano: {automovel.Value["Ano"]}");
                        Console.WriteLine($"Cor: {automovel.Value["Cor"]}");
                        Console.WriteLine($"Valor: R$ {automovel.Value["Valor"]}");

                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Nenhum automóvel encontrado para essa marca.");
                }
            }

            // Sair
            else if (opcao == "5")
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
