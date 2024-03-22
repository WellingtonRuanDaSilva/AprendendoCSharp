List<int> numeros = new List<int> { 1, 2, 3 , 4, 5, 6, 7, 8, 9, 10 };

var numerosPares = numeros.Where(x => x % 2 == 0);

Console.WriteLine("Números Pares:");
foreach (var numero in numerosPares)
{
    Console.WriteLine(numero);
}

List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leao", "cobra", "pao", "oi"};

var palavrasFiltradas = palavras.Where(p => p.Length > 3).OrderBy(p => p.Length);

Console.WriteLine("\nPalavras com amis de 3 caracteres, ordenadas por cumprimerno:");
foreach(var palavra in palavrasFiltradas)
{
    Console.WriteLine(palavra);
}