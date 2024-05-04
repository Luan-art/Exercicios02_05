using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6_02_05
{
    internal class PilhaAluno
    {
        Aluno topo;

        public PilhaAluno()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            return topo == null;
        }

        public void push(Aluno aux)
        {
            if (isEmpty())
            {
                this.topo = aux;
            }
            else
            {
                aux.setProxima(topo);
                this.topo = aux;
            }
        }

        public void RunOver()
        {
            Aluno aux = topo;

            do
            {
                Console.WriteLine("Nome do Aluno " + aux.getNome() + " " + aux.getNumero());
                aux = aux.getProximo();

            } while (aux != null);

            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();
        }

        public void runOverNoNotes(int[] filaNota)
        {
            Aluno aux = topo;
             do
             {
                if(!checkNoNotes(aux, filaNota))
                {
                    Console.WriteLine("Nome aluno sem nota: " + aux.getNome() + " Número: " + aux.getNumero());

                }
                aux = aux.getProximo();

             }while (aux != null);

            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        public bool checkNoNotes(Aluno aluno, int[] filaNota)
        {
            for (int i = 0; i < filaNota.Length; i++)
            {
                if (filaNota[i] == aluno.getNumero())
                {
                    return true;  
                }
            }

            return false;  
        }

        public void pop(int[] filaNota)
        {
            Aluno aux = topo;

            if(!checkNoNotes(aux, filaNota))
            {
                topo = topo.getProximo();

            }
            else
            {
                Console.WriteLine("Aluno possui nota");
                Console.ReadKey();
            }

        }
    }
}


   



