
namespace Bibliotech.Lib.Modelos
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public Livro(string titulo, string autor) : base(titulo)
        {
            Autor = autor;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Livro: {Titulo} | Autor: {Autor}");
        }
    }
}
