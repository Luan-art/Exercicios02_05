using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios02_05
{
    internal class Inteiro
    {
        int numero;
        Inteiro? anterior;

        public Inteiro(int numero)
        {
            this.numero = numero;      
            anterior = null;
        }

        public void setAnterior(Inteiro topo)
        {
            this.anterior = topo;
        }

        public Inteiro? getAnterior()
        {
            return anterior;
        }

        public int getNumero()
        {
            return numero;
        }

    }
}
