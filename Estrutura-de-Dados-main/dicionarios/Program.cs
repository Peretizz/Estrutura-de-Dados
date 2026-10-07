using System.Collections;

Hashtable phoneBook = new Hashtable() {
    {"Edilio Junior", "0000"},
    {"Bruno Antonio", "1111"},
    {"Guindane", "2222"}
};

//Adicionando em tempo de execução
phoneBook["Bolsonaro"] = "3333";

// Tratando possível erro de duplicidade
// da chave

try
{
    phoneBook.Add("Bolsonaro", "3333");
}
catch (System.ArgumentException ae)
{
    Console.WriteLine("Chave já existente. " + ae.Message);
}
catch (System.Exception ex)
{
    Console.WriteLine("Erro imprevisto. " + ex.Message);
}

//percorrendo valores TableHash
Console.WriteLine("Caderninho de telefone:");
if (phoneBook.Count == 0)
{
    Console.WriteLine("Agenda vazia.");
}
else
{
    int i = 1;
    foreach (DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{i}. {entry.Key} - {entry.Value}");
        i++;
    }
}

//Busca em chave
Console.WriteLine("");
Console.WriteLine("Busca por nome:");
string name = Console.ReadLine();

if (phoneBook.Contains(name))
{
    string number = (string)phoneBook[name];
}
else
{
    Console.WriteLine($"{name} não encontrado.");
}

// dicionarios

Dictionary<string, string> dic =
    new Dictionary<string, string>()
    {
    {"Carlos", "1234"},
    {"Gope", "4321"},
    };

string value = dic["Carlos"];
dic["Carlos"] = "5678"; // atualizando valor
foreach(KeyValuePair<string, string> pair in dic)
{
    Console.WriteLine($"Chave: {pair.Key}, Valor: {pair.Value}");
}