using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2_02_05
{
    internal class FilaInt
    {
        Inteiro? head;
        Inteiro? tail;

        public FilaInt()
        {
            this.head = null;
            this.tail = null;
        }

        public bool isEmpty()
        {
            return head == null && tail == null;
        }

        public void push(Inteiro aux)
        {
            if (isEmpty())
            {
                head = tail = aux;
            }
            else
            {
                tail.setNext(aux);
                tail = aux;
            }
        }

        public int stackCounter()
        {
            Inteiro aux = head;
            int i = 0;

            while (aux != null)
            {
                i++;
                aux = aux.getNext();
            }

            return i;
        }

        public void runOver()
        {
            Inteiro aux = head;

            do
            {
                Console.WriteLine(aux.getNumero());
                aux = aux.getNext();

            } while (aux != null);

            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverHigher()
        {

            Inteiro aux = head;
            int higher = aux.getNumero();
            while (aux != null)
            {
                if (aux.getNumero() > higher)
                {
                    higher = aux.getNumero();

                }

                aux = aux.getNext();

            }

            Console.WriteLine("\nMaior numero " + higher);
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverSmallest()
        {
            Inteiro aux = head;
            int smallest = head.getNumero();

            while (aux != null)
            {
                if (aux.getNumero() < smallest)
                {
                    smallest = aux.getNumero();

                }

                aux = aux.getNext();
            }

            Console.WriteLine("\nMenor numero " + smallest);
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverAvarage()
        {

            Inteiro aux = head;
            int numeroElementos = stackCounter();
            int somaTatalElementos = 0;
            do
            {
                somaTatalElementos += aux.getNumero();
                aux = aux.getNext();

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

            Inteiro aux = head;
            int i = 0;
            do
            {
                if (aux.getNumero() % 2 == 0)
                {
                    Console.WriteLine(aux.getNumero());
                    i++;
                }
                aux = aux.getNext();

            } while (aux != null);


            Console.WriteLine("\nTemos ao todo " + i + " Numeros Pares");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public void runOverOdd()
        {

            Inteiro aux = head;
            int i = 0;
            do
            {
                if (aux.getNumero() % 2 != 0)
                {
                    Console.WriteLine(aux.getNumero());
                    i++;
                }
                aux = aux.getNext();

            } while (aux != null);


            Console.WriteLine("\nTemos ao todo " + i + " Numeros Impares");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();
        }

        public FilaInt copyStack()
        {
            FilaInt copyStack = new FilaInt();

            Inteiro aux = head;
            int n;

            do
            {
                n = aux.getNumero();
                Inteiro inteiro = new Inteiro(n);
                copyStack.push(inteiro);
                aux = aux.getNext();

            } while (aux != null);

            return copyStack;
        }
    }
}
