using Bibliotech.Lib.Modelos;

class Program
{
    static List<ItemBiblioteca> itens = new List<ItemBiblioteca>();

    static void Main(string[] args)
    {

        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine(@"
██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░██╗░░██╗
██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║░░██║
██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║
██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║
██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║
╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝
");
            Console.WriteLine("Bem-vindo ao BIBLIOTECH! Um sistema simples para " +
                "gerenciar livros e revistas. Você pode adicionar novos itens ou listar os cadastrados");
            Console.WriteLine("\n┌──────────────────────┐");
            Console.WriteLine("│         MENU         │");
            Console.WriteLine("├──────────────────────┤");
            Console.WriteLine("│ [1] Adicionar Livro  │");
            Console.WriteLine("│ [2] Adicionar Revista│");
            Console.WriteLine("│ [3] Listar Itens     │");
            Console.WriteLine("│ [4] Sair             │");
            Console.WriteLine("└──────────────────────┘");
            Console.Write("\nEscolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            switch (opcao)
            {
                case 1:
                    AdicionarLivro();
                    break;
                case 2:
                    AdicionarRevista();
                    break;
                case 3:
                    ListarItens();
                    break;
                case 4:
                    Console.WriteLine("\nEncerrando o programa...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }

        } while (opcao != 4);
    }

    static void AdicionarLivro()
    {
        Console.Clear();

        string titulo;

        do
        {
            Console.Write("Digite o título do livro: ");
            titulo = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("Título inválido. DIgite novamente");
            }
        } while (string.IsNullOrEmpty(titulo));

        string autor;
       
        do
        {
            Console.Write("Digite o autor do livro: ");
            autor = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(autor))
            {
                Console.WriteLine("Autor inválido. Digite novamente.");
            }
        } while (string.IsNullOrEmpty(autor));

        itens.Add(new Livro(titulo, autor));
        Console.WriteLine("\nLivro adicionado com sucesso!");
        Console.ReadKey();
    }

    static void AdicionarRevista()
    {
        Console.Clear();

        string titulo;

        do
        {
            Console.Write("Digite o título da revista: ");
            titulo = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("Título inválido. Digite novamente");
            }
        } while (string.IsNullOrEmpty(titulo));

        int edicao;

        do
        {
            Console.Write("Digite a edição da revista: ");
        } while (!int.TryParse(Console.ReadLine(), out edicao) || edicao <= 0);

        itens.Add(new Revista(titulo, edicao));
        Console.WriteLine("\nRevista adicionada com sucesso!");
        Console.ReadKey();
    }

    static void ListarItens()
    {
        Console.Clear();
        Console.WriteLine("Itens cadastrados\n");

        if (itens.Count == 0)
        {
            Console.WriteLine("Nenhum item cadastrado ainda");
        }
        else
        {
            foreach (var item in itens)
            {
                item.ExibirDetalhes();
            }
            Console.WriteLine($"\nTotal de itens: {ItemBiblioteca.TotalItens}");
        }

        Console.ReadKey();
    }
}
