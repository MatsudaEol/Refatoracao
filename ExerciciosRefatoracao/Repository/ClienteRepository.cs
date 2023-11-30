using ExerciciosRefatoracao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Repository
{
    public class ClienteRepository
    {
        
        List<Cliente> lstClientes = new List<Cliente>();
        public List<Cliente> obterTodosClientes()
        {
            return lstClientes;
        }

        public int Add(Cliente cliente)
        {
            int id = lstClientes.Count + 1;
            lstClientes.Add(cliente);
            return id;
        }

        //public void UpdateEnderecoEntrega(string endEntregaLogradouro, string endEntregaNumero, string endEntregaComplemento, string endEntregaBairro, string endEntregaCEP, string endEntregaMunicipio, string endEntregaUF)
        //{
        //    EndEntregaLogradouro = endEntregaLogradouro;
        //    EndEntregaNumero = endEntregaNumero;
        //    EndEntregaComplemento = endEntregaComplemento;
        //    EndEntregaBairro = endEntregaBairro;
        //    EndEntregaCEP = endEntregaCEP;
        //    EndEntregaMunicipio = endEntregaMunicipio;
        //    EndEntregaUF = endEntregaUF;
        //}

        //public void UpdateEnderecoCobranca(string endCobrancaLogradouro, string endCobrancaNumero, string endCobrancaComplemento, string endCobrancaBairro, string endCobrancaCEP, string endCobrancaMunicipio, string endCobrancaUF)
        //{
        //    EndCobrancaLogradouro = endCobrancaLogradouro;
        //    EndCobrancaNumero = endCobrancaNumero;
        //    EndCobrancaComplemento = endCobrancaComplemento;
        //    EndCobrancaBairro = endCobrancaBairro;
        //    EndCobrancaCEP = endCobrancaCEP;
        //    EndCobrancaMunicipio = endCobrancaMunicipio;
        //    EndCobrancaUF = endCobrancaUF;
        //}

    }
}
