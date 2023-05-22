using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Arquivo
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cidade = cidade;
            Rg = rg;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return Nome + "|" + Telefone + "|" + Cidade + "|" + Rg + "|" + Cpf;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa &&
                   Cpf == pessoa.Cpf;
        }
    }
}
