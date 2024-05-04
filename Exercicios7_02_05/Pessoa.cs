using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicios7_02_05
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string profissao;

        public Pessoa(string nome, int idade, string profissao)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public string getProfissao()
        {
            return profissao;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setIdade(int idade)
        {     
            this.idade = idade;
        }

        public void setProf(string profissao)
        {
            this.profissao = profissao;
        }

        public int IdadeEmBissexto()
        {
            int idadeB = 0;
            int anoNascimento = DateTime.Now.Year - idade; 
            int anoAtual = DateTime.Now.Year;

            while (anoNascimento <= anoAtual)
            {
                if ((anoNascimento % 4 == 0 && anoNascimento % 100 != 0) || (anoNascimento % 400 == 0))
                {
                    idadeB++;
                }
                anoNascimento++;
            }
     
            return idadeB;

        }

        public override string? ToString()
        {
            return "Nome: " + nome + " Idade: " + idade + " Porfissão " + profissao; 
        }
    }
}
