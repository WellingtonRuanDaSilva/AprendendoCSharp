using System.Transactions;

List<double> numeros = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5};
double soma = 0;

foreach (double numero in numeros)
{
    soma += numero;
}

double media = soma / numeros.Count;
Console.WriteLine($"A média dos elementos da lista é: {media}");   