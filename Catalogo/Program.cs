class Jogo
{
    public string Nome { get; set; }
    public string Genero { get; set; }
    public int AnoLancamento { get; set; }

    public Jogo (string nome, string genero, int anoLancamento)
    {
        Nome = nome;
        Genero = genero;
        AnoLancamento = anoLancamento;
    }
}

class CatalogoDeJogos
{
    private List<Jogo> Jogos { get; set; }

    //propriedade que retorna se o catalogo esta vazio
    public bool CatalogoVazio => Jogos.Count == 0;

    //construtor para incializar o catalogo de jogos vazio
    public CatalogoDeJogos()
    {
        Jogos = new List<Jogo>();
    }

    //metodo para adcionar um jogo no catalogo
    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }

    //metodo para listar todos os jogo no catalogo
    public void ListaJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio");
        }
        else
        {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }
}








