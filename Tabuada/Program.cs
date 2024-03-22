Console.Write("Digite um número para sua tabuada: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nTabuada do {numero}:\n");

for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}