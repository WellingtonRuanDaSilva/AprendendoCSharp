Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    {"Qual é a capital do Brasil?", "Brasília" },
    {"Quanto é 7 vezes 8?", "56" },
    {"QUem escreveu 'Romeu e Julieta'?", "William Shakespeare" }
};

int pontuacao = 0;

foreach (var pergunta in perguntasERespostas)
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Sua resposta: ");
    string respostaUsuario = Console.ReadLine();

    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Correo!\n");
        pontuacao++;
    } else
    {
        Console.WriteLine($"Incorreto . Aresposta correta é: {pergunta.Value}\n");
    }
}
Console.WriteLine($"Pontuação Final: {pontuacao} de {perguntasERespostas.Count}");