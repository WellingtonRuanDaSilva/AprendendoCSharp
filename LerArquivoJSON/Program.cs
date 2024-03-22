using LerArquivoJSON;
using System.Text.Json;

string fileName = "pessoa.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

    Console.WriteLine("Informações das Pessoas: ");
    foreach(var pessoa in pessoas)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
    }
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}