using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech.Lib.Modelos
{
    public class Revista : ItemBiblioteca
    {
        public int Edicao { get; set; }

        public Revista(string titulo, int edicao) : base(titulo)
        {
            Edicao = edicao;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Revista: {Titulo} | Edição: {Edicao}");
        }
    }
}
