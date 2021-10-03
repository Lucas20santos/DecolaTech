using System;
using System.IO;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static BancoDados banco = new BancoDados(nomeArquivo: "bancoDados.txt", caminhoArquivo: "/home/luca/Documentos/Github/DecolaTech/APPCadastroSerie/DIO.Series/arquivo/");
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
                        InserirCarros();
                        break;
                    case "3":
                        AtualizarCarros();
                        break;
                    case "4":
                        ExcluirCarros();
                        break;
                    case "5":
                        VisualizarCarros();
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

        private static void VisualizarCarros()
        {
            Console.Write("Digite o id do Carros: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void ExcluirCarros()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarCarros()
        {
            Console.Write("Digite o id da série: ");
            int indiceCarro = int.Parse(Console.ReadLine());

            foreach (var i in Enum.GetValues(typeof(Carros)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Carros), 1));
            }

            Console.Write("Digite o modelo entre as opções acime: ");
            int entradaModelo = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço do carro: ");
            float precoCarro = float.Parse(Console.ReadLine());

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Carros atualizaCarro = new Carros(id: indiceCarro,
                                              carros: (Modelos)entradaModelo,
                                              preco: precoCarro,
                                              ano: entradaAno,
                                              descricao: entradaDescricao);
        
            repositorio.Atualiza(indiceCarro, atualizaCarro);
        }

        private static void InserirCarros()
        {
            
            foreach (var i in Enum.GetValues(typeof(Carros)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Carros), i));
            }
            Console.Write("Digite o modelo entre as opções acime: ");
            int entradaModelo = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço do carro: ");
            float precoCarro = float.Parse(Console.ReadLine());

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Carros novaSerie = new Carros(id: repositorio.ProximoId(),
                                              carros: (Modelos)entradaModelo,
                                              preco: precoCarro,
                                              ano: entradaAno,
                                              descricao: entradaDescricao);
            
            repositorio.Insere(novaSerie);
        
            // INSERIR NO BANCO DE DADOS
            banco.insereNoBanco(id: repositorio.ProximoId(), carros: (Modelos)entradaModelo,
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
