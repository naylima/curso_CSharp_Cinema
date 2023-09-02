namespace Cinema;
internal class Program
{
    private static void Main(string[] args)
    {
        Filme filme = new Filme("As Branquelas", 2004, 109);

        Sala sala = new Sala() { QuantidadeCadeiras = 60, Numero = 2 };

        Sessao sessao = new Sessao(sala, new DateTime(2023, 08, 29, 14, 30, 0));

        sessao.AddFilme(filme);
        Console.WriteLine(sessao);
    }
}
