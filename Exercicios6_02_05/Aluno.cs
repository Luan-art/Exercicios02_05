//1 - Cadastre um Aluno(Nome e numero) de cada vez em uma pilha, os número dos 
//alunos é automático a partir do 1 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6_02_05
{
    internal class Aluno
    {
        string nome;
        int numero;
        Aluno? proximo;

        public Aluno(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
            proximo = null;
        }
        public int getNumero()
        {
            return numero;
        }

        public string getNome()
        {
            return nome;
        }

        public Aluno? getProximo()
        {
            return proximo;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setProxima(Aluno? proximo)
        {
            this.proximo = proximo;
        }

    }
}
