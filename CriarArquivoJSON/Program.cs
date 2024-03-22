using CriarArquivoJSON;
using System.Text.Json;

List<Pessoa> pessoas = new List<Pessoa>();

while (true)
{
    Pessoa pessoa = new Pessoa();
    Console.Write("Digite o nome (ou 'sair' para encerrar): ");
    string nome = Console.ReadLine();

    if (nome.ToLower() == "sair")
        break;

    pessoa.Nome = nome;

    Console.Write("Digite a idade: ");
    pessoa.Idade = int.Parse(Console.ReadLine());

    Console.Write("Digite o e-mail: ");
    pessoa.Email = Console.ReadLine();

    pessoas.Add(pessoa);
}

string JsonString = JsonSerializer.Serialize(pessoas);

string fileName = "pessoas.json";

File.WriteAllText(fileName, JsonString);

Console.WriteLine($"Os dados foram salvos em {fileName}");
