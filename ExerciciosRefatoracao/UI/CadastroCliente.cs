using ExerciciosRefatoracao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI
{
    public class CadastroCliente
    {
        ClienteRepository _repository;
        public CadastroCliente(ClienteRepository repository) 
        {
            this._repository = repository;        
        }

        public void Load()
        {
            string tipoPessoa;

            do
            {
                MostrarCabecalho();
                Console.Write("Tipo Cliente (F - Física / J - Jurídica): ");
                tipoPessoa = Console.ReadLine();

                if (!tipoPessoa.Equals("F") && !tipoPessoa.Equals("J"))
                {
                    Console.WriteLine("Tipo de Cliente inválido! Opções válidas F - Física / J - Jurídica!");
                    Console.ReadKey();                    
                }
            } while (!tipoPessoa.Equals("F") && !tipoPessoa.Equals("J"));

            if (tipoPessoa.Equals("F"))
                new CadastroPF(this._repository).Load();
            else
                new CadastroPJ(this._repository).Load();
        }

        private void MostrarCabecalho()
        {
            Console.Clear();
            Console.WriteLine("\n[CADASTRO DE CLIENTE PESSOA FÍSICA]");
        }

    }
}
