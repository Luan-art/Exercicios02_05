using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6_02_05
{
    internal class FilaNota
    {
        Nota? head;
        Nota? tail;
    
        public FilaNota()
        {
            this.head = null;
            this.tail = null;  
        }
        
        public bool twoNotes(int numero)
        {
            int contador = 0;

            Nota aux = head;
            while (aux != null)
            {
                if (aux.getNumeroAluno() == numero)
                {
                    contador++;
                }
                aux = aux.getAnterior();
            }

            return contador == 2;


        }
        public void push(Nota aux)
        {
            if (isEmpty())
            {
                head = tail = aux;
            }
            else
            {
                tail.setAnterior(aux);
                tail = aux;
            }
        }

        public bool isEmpty()
        {
            return head == null && tail == null;
        }

        public void pop()
        {
            if (!isEmpty())
            {
                if (tail == head)
                {
                    head = tail = null;
                }

                else
                {
                    this.head = head.getAnterior();
                }
            }
        }

            
        public void RunOver()
        {
            Nota aux = head;
            do
            {
                Console.Write("Nota " + aux.getNota());
                Console.Write(" Numero Aluno " + aux.getNumeroAluno());
                Console.WriteLine();
                aux = aux.getAnterior();

            } while (aux != null);

            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();
        }

        internal float caulcarMedia(int numeroMedia)
        {
            float soma = 0;

            Nota aux = head;
            while (aux != null)
            {
                if (aux.getNumeroAluno() == numeroMedia)
                {
                    soma += aux.getNota();
                }
                aux = aux.getAnterior();
            }

            return soma / 2;
        }

        internal int queueSize()
        {
            Nota aux = head;
            int contado = 0;
            
            while (aux != null)
            {
                contado++;
                aux = aux.getAnterior(); 

            }

            return contado;
        }

        internal int[] getNumerosNotas(int tamanhoFila)
        {
            Nota aux = head;
            int[] numerosDasNotas = new int[tamanhoFila];
            
            for (int i = 0; i < tamanhoFila; i++) {
                numerosDasNotas[i] = aux.getNumeroAluno();
                aux = aux.getAnterior();
            }

            return numerosDasNotas;
        }
    }
}


