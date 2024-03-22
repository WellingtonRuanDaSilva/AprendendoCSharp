
    Console.WriteLine("Calculadora\n");

    Console.WriteLine("Escolha a operação: \n");
    Console.WriteLine("Digite 1 para soma");
    Console.WriteLine("Digite 2 para subrtração");
    Console.WriteLine("Digite 3 para multiplicação");
    Console.WriteLine("Digite 4 para divisão");
    Console.WriteLine("Digite 0 para sair\n");
    Console.Write("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaCalculadora = int.Parse(opcaoEscolhida);
    Console.Clear();

    Console.Write("Digite o primeiro numero: ");
    double numero1 = double.Parse(Console.ReadLine()!);
    Console.Clear();

    Console.Write("Digite o segundo numero: ");
    double numero2 = double.Parse(Console.ReadLine()!);
    Console.Clear();

    double resultado = 0;

    switch (opcaoEscolhidaCalculadora)
    {
        case 1:
            resultado = numero1 + numero2;
            break;
        case 2:
            resultado = numero1 - numero2;
            break;
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            resultado = numero1 / numero2;
            break;
        default:
            Console.WriteLine("Operação Inválida.");
            return;
    }


    Console.WriteLine($"Resultado da operação: {resultado}");


