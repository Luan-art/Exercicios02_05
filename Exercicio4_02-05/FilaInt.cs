using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios4_02_05
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
    }
}
