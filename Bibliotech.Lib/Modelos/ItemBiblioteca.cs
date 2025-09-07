
namespace Bibliotech.Lib.Modelos
{
    file class AuxiliarInterno
    { 
        public string Info { get; set; } = "Classe visível apenas neste arquivo";
    }

    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        private int id;
        protected string Descricao;
        internal string CodigoInterno { get; set; }
        protected internal DateTime DataCadastro { get; set; }
        private protected string CodigoRestrito { get; set; }
        public static int TotalItens { get; private set; }

        public ItemBiblioteca(string titulo)
        {
            Titulo = titulo;
            id = new Random().Next(1, 10000);
            TotalItens++;
        }

        public abstract void ExibirDetalhes();
    }
}
