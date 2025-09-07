using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
