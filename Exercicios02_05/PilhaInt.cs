using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios02_05
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
                aux.setAnterior(topo);
                this.topo = aux;
            }
        }

        public int stackCounter()
        {
            Inteiro aux = topo;
            int i = 0;

            while (aux != null)
            {
                i++;
                aux = aux.getAnterior();
            }

            return i;
        }

        public void runOver()
        {
            Inteiro aux = topo;

            do
            {
                Console.WriteLine(aux.getNumero());
                aux = aux.getAnterior();

            } while (aux != null);

            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverHigher()
        {

            Inteiro aux = topo;
            int higher = aux.getNumero();
            while (aux != null)
            {
                if (aux.getNumero() > higher)
                {
                    higher = aux.getNumero();

                }

                aux = aux.getAnterior();

            }

            Console.WriteLine("\nMaior numero " + higher);
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverSmallest()
        {
            Inteiro aux = topo;
            int smallest = topo.getNumero();

            while (aux != null)
            {
                if (aux.getNumero() < smallest)
                {
                    smallest = aux.getNumero();

                }

                aux = aux.getAnterior();
            }

            Console.WriteLine("\nMenor numero " + smallest);
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverAvarage()
        {

            Inteiro aux = topo;
            int numeroElementos = stackCounter();
            int somaTatalElementos = 0;
            do
            {
                somaTatalElementos += aux.getNumero();
                aux = aux.getAnterior();

            } while (aux != null);

            if (numeroElementos != 0)
            {
                float media = somaTatalElementos / numeroElementos;
                Console.WriteLine("\nA média é " + media);
                Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            }

            Console.ReadKey();

        }

        public void runOverEven()
        {

            Inteiro aux = topo;
            int i = 0;
            do
            {
                if (aux.getNumero() % 2 == 0)
                {
                    Console.WriteLine(aux.getNumero());
                    i++;
                }
                aux = aux.getAnterior();

            } while (aux != null);


            Console.WriteLine("\nTemos ao todo " + i + " Numeros Pares");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverOdd()
        {

            Inteiro aux = topo;
            int i = 0;
            do
            {
                if (aux.getNumero() % 2 != 0)
                {
                    Console.WriteLine(aux.getNumero());
                    i++;
                }
                aux = aux.getAnterior();

            } while (aux != null);


            Console.WriteLine("\nTemos ao todo " + i + " Numeros Impares");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();
        }

        public PilhaInt copyStack()
        {
            PilhaInt copyStack = new PilhaInt();

            Inteiro aux = topo;
            int n;

            do
            {
                n = aux.getNumero();
                Inteiro inteiro = new Inteiro(n);
                copyStack.push(inteiro);
                aux = aux.getAnterior();

            } while (aux != null);

            return copyStack;
        }


    }

}

