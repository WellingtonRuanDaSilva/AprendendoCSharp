Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

notasAlunos["Joao"] = new List<double> { 8.5, 9.0, 7.5 };
notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

foreach (var alunos in notasAlunos)
{
    double soma = 0;
    for (int i = 0; i < alunos.Value.Count; i++)
    {
        soma += alunos.Value[i];
    }
    double media = soma / alunos.Value.Count;
    Console.WriteLine($"Média de {alunos.Key}: {media}");
}