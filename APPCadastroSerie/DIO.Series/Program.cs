using System;
using System.IO;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static BancoDados banco = new BancoDados(nomeArquivo: "bancoDados.txt",
                                                caminhoArquivo: "/home/luca/Documentos/Github/DecolaTech/APPCadastroSerie/DIO.Series/arquivo/");
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();


            while(opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarCarros();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por ultilizar nossos serviços");
            Console.ReadLine();

        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (var i in Enum.GetValues(typeof(Carros)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Carros), 1));
            }

            Console.Write("Digite o genero entre as opções acime: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series atualizaSerie = new Series(id: indiceSerie,
                                              carros: (Carros)entradaGenero,
                                              titulo: entradaTitulo,
                                              ano: entradaAno,
                                              descricao: entradaDescricao);
        
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void InserirSerie()
        {
            
            foreach (var i in Enum.GetValues(typeof(Carros)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Carros), i));
            }
            Console.Write("Digite o genero entre as opções acima: ");
            int entradaCarro = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de Inicio da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Seŕie: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(), carros: (Carros)entradaCarro, 
                                          titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno);
            
            repositorio.Insere(novaSerie);
        
            // INSERIR NO BANCO DE DADOS
            banco.insereNoBanco(id: repositorio.ProximoId(), carros: (Carros)entradaCarro,
                                descricao: entradaDescricao);
        
        }

        private static void ListarCarros()
        {
            Console.WriteLine("Listar Carros");

            banco.listarCarros();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
