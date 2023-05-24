using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Arquivo_WF
{
    internal class Aluno: Pessoa
    {
        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, string codCurso, string nomeCurso)
            : base(nome, telefone, cidade, rg, cpf)
        {
            Matricula = matricula;
            CodCurso = codCurso;
            NomeCurso = nomeCurso;
        }

        public string Matricula { get; set; }
        public string CodCurso { get; set; }
        public string NomeCurso { get; set; }

        public override string ToString()
        {
            return Nome + "|" + Telefone + "|" + Cidade + "|" + Rg + "|" + Cpf + "|" + Matricula + "|" + CodCurso + "|" + NomeCurso ;
        }

    }
}
