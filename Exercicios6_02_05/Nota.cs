//2- Cadastre uma Nota ( Numero Aluno e Nota e os cadastre numa fila, uma nota
//só pode ser cadastrada se pertencer a um aluno na pilha

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6_02_05
{
    internal class Nota
    {
        int numeroAluno;
        float nota;
        Nota? anterior;

        public Nota(int numeroAluno, float nota)
        {
            this.numeroAluno = numeroAluno;
            this.nota = nota;
            anterior = null;
        }

        public int getNumeroAluno()
        {
            return numeroAluno;
        }

        public float getNota()
        {
            return nota;
        }

        public Nota? getAnterior()
        {
            return anterior;
        }

        public void setNumero(int numeroAluno)
        {
            this.numeroAluno = numeroAluno;
        }

        public void setNota(float nota)
        {
            this.nota = nota;
        }

        public void setAnterior(Nota? anterior)
        {
            this.anterior = anterior;  
        }
    }
}
