var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> {8, 7, 6} },
        { "Java", new List<int>{7, 6, 5} },
        { "Python", new List<int> { 9, 8, 8} }
    } },
     { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4} },
        { "Java", new List<int>{ 8, 7, 6} },
        { "Python", new List<int> { 6, 10, 5} }
    } },
     { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10} },
        { "Java", new List<int>{ 8, 8, 8} },
        { "Python", new List<int> { 7, 7, 7} }
    } }
};

List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
double mediaMariaEmPython = notasPythonMaria.Average();
Console.WriteLine(mediaMariaEmPython);

