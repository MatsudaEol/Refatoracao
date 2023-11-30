using ExerciciosRefatoracao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI
{
    public class TelaPrincipal
    {
        ClienteRepository _repository;
        public TelaPrincipal(ClienteRepository repository,
                             ConsoleColor ForegroundColor)
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;            
            Console.ForegroundColor = ForegroundColor;
            this._repository = repository;
        }

        public void Load()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(MostrarCabecalho());
                Console.WriteLine(MostrarMenu());
                opcao = LerOpcaoMenu();
                ProcessarOpcaoMenu(opcao);
            } while (opcao != "0");
        }

        private static string MostrarCabecalho()
        {
            return "[ CADASTRO DE CLIENTES - EMPRESA FORNECEDORA DO BRASIL ]\n";
        }

        private static string MostrarMenu()
        {
            string menu = "   Escolha uma opção:\n\n" +
                            "   1 - Cadastrar Cliente\n" +
                            "   2 - Listar Clientes\n" +
                            "   0 - Sair do Programa \n";
            return menu;
        }

        private static string LerOpcaoMenu()
        {
            string opcao;
            Console.Write("Opção desejada: ");
            opcao = Console.ReadLine();
            return opcao;
        }

        private void ProcessarOpcaoMenu(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    new CadastroCliente(this._repository).Load();
                    break;
                case "2":
                    new ListaClientes(this._repository).Load();
                    break;
                case "0":
                    Console.WriteLine("Obrigado por utilizar o programa.");
                    break;
                default:
                    Console.WriteLine("Opção de menu inválida!");
                    break;
            }
        }
    }
} 
