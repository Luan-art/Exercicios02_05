using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2_02_05
{
    internal class Inteiro
    {
        int numero;
        Inteiro? proximo;

        public Inteiro(int numero)
        {
            this.numero = numero;
            proximo = null;
        }

        public void setNext(Inteiro aux)
        {
            this.proximo = aux;
        }

        public Inteiro? getNext()
        {
            return proximo;
        }

        public int getNumero()
        {
            return numero;
        }

    }
}
