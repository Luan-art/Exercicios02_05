using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios5_02_05
{
    internal class PilhaInt
    {

        Inteiro topo;

        public PilhaInt()
        {
            topo = null;
        }

        public bool isEmpty()
        {

            return (topo == null);
        }

        public void push(Inteiro aux)
        {
            if (isEmpty())
            {
                this.topo = aux;
            }
            else
            {
                aux.setNext(topo);
                this.topo = aux;
            }
        }

        public void runOver()
        {
            Inteiro aux = topo;

            do
            {
                Console.WriteLine(aux.getNumero());
                aux = aux.getNext();

            } while (aux != null);

            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        internal int[] runOverNumbers()
        {
            Inteiro aux = topo;
            int[] numeros = new int[10];
            int i = 0;

            while (aux != null && i < 10)
            {
                numeros[i] = aux.getNumero();
                aux = aux.getNext();
                i++;
            }

            return numeros;
        }
    }
}
