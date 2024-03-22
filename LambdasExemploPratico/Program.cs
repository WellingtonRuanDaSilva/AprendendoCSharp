//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
//List<int> numerosPares = numeros.FindAll(BuscarNumerosPares);
//
//bool BuscarNumerosPares(int numero)
//{
//    return numero % 2 == 0;
//}
//foreach (int numero in numerosPares)
//{
//    Console.WriteLine(numero);
//}

//     Modo com Lambda

using System.Threading.Channels;

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

numerosPares.ForEach(pares => Console.WriteLine(pares));


//public int Somar(int a, int b)
//{
//    int resultado = a + b;
//    return resultado;
//}

// Modo com Lambda
//public int Somar(int a, int b) => a + b;