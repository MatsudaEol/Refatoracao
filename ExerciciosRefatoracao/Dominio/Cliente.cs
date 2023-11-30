using System;

namespace ExerciciosRefatoracao.Dominio
{
    public class Cliente
    {
        public string RazaoSocial { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        public Endereco EndEntrega { get; private set; } = new Endereco();
        public Endereco EndCobranca { get; private set; } = new Endereco();
        public Endereco EndFaturamento { get; private set; } = new Endereco();

        public void SetEnderecoFaturamento(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            SetEndereco(EndFaturamento, logradouro, numero, complemento, bairro, cep, municipio, uf);
        }

        public void SetEnderecoEntrega(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            SetEndereco(EndEntrega, logradouro, numero, complemento, bairro, cep, municipio, uf);
        }

        public void SetEnderecoCobranca(string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            SetEndereco(EndCobranca, logradouro, numero, complemento, bairro, cep, municipio, uf);
        }

        private void SetEndereco(Endereco endereco, string logradouro, string numero, string complemento, string bairro, string cep, string municipio, string uf)
        {
            endereco.Logradouro = logradouro;
            endereco.Numero = numero;
            endereco.Complemento = complemento;
            endereco.Bairro = bairro;
            endereco.CEP = cep;
            endereco.Municipio = municipio;
            endereco.UF = uf;
        }

        public string GetTextoEndereco(Endereco endereco)
        {
            return $"Endereço: {endereco.Logradouro} {endereco.Numero} {endereco.Complemento} - {endereco.Bairro} - CEP {endereco.CEP} - {endereco.Municipio} - {endereco.UF}";
        }

        public override string ToString()
        {
            return $"===Dados do Cliente===\n{(string.IsNullOrEmpty(this.CPF) ? $"CNPJ: {this.CNPJ}\nRazão Social: {this.RazaoSocial}" : $"CPF: {this.CPF}\nNome: {this.Nome}")}\n{GetTextoEndereco(EndCobranca)}\n{GetTextoEndereco(EndEntrega)}\n{GetTextoEndereco(EndFaturamento)}";
        }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
    }
}
