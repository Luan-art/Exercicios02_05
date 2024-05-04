 /*- []  6 - Faça um programa que apresente o seguinte Menu de Opc :
    - []  A)Cadastrar aluno
    - [ ] B)Cadastrar Nota
    - [ ] C)Calcular média
    - [ ] D) Listar nome de alunos sem nota
    - [ ] E) Excluir aluno
    - [ ] F) Excluir nota
    - [ ] G) Sair


3 - o usuário deve digitar o numero do aluno para mostrar a sua média, cada 
aluno tem duas Notas. (caso n exista nota ou usuário, avisar usuário)

4-Um aluno só pode ser excluído caso não tenha Notas

5-As notas devem ser excluídas respeitando a regra da fila-*/

using Exercicios6_02_05;

int opc, contadorAluno = 1;
PilhaAluno pilhaAluno = new PilhaAluno();
FilaNota filaNota = new FilaNota();
int tamanhoFila;
int[] notasComALunos;

do
{
    Console.Clear();
    Console.WriteLine("Menu principal");
    Console.WriteLine("Opções");
    Console.WriteLine("1 - Cadastrar Um Aluno");
    Console.WriteLine("2 - Cadastrar Nota");
    Console.WriteLine("3 - Calcular média nota");
    Console.WriteLine("4 - Listar nome de alunos sem nota");
    Console.WriteLine("5 - Excluir aluno");
    Console.WriteLine("6 - Excluir nota");
    Console.WriteLine("7 - Imprimir Lista de Alunos");
    Console.WriteLine("8 - Imprimir Liste de Notas");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Informar a opção desejada: < >\b\b");

    
    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            string nome;
            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Aluno aluno = new Aluno(nome, contadorAluno);
            contadorAluno++;
            pilhaAluno.push(aluno);
            break;
        case 2:
         
            float n;
            int numeroAluno;

            Console.WriteLine("Digite a nota do aluno: ");
            n = float.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite o número do aluno dessa nota: ");
                numeroAluno = int.Parse(Console.ReadLine());

                if (numeroAluno > contadorAluno || numeroAluno <= 0)
                {
                    Console.WriteLine("Numero invalido");
                    Console.ReadKey();
                } 
            } while (numeroAluno > contadorAluno);
     

            if (filaNota.twoNotes(numeroAluno))
            {
                Console.WriteLine("Aluno já tem duas Notas Cadastradas");
                Console.ReadKey();
            }
            else 
            {
                Nota nota = new Nota(numeroAluno, n);

                filaNota.push(nota);
            }
            break;

        case 3:
            Console.WriteLine("Digite o numero do aluno que deseja caulcular Nota: ");
            int numeroMedia = int.Parse(Console.ReadLine());

            if (!filaNota.isEmpty())
            {
                if (filaNota.twoNotes(numeroMedia))
                {
                    float media = filaNota.caulcarMedia(numeroMedia);
                    Console.WriteLine("A média desse aluno é " + media);
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Aluno possui só uma ou nenhuma Nota");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Fila vazia");
                Console.ReadKey();
            }
            break;
        case 4:
            tamanhoFila = filaNota.queueSize();
            notasComALunos = filaNota.getNumerosNotas(tamanhoFila); 
            
           pilhaAluno.runOverNoNotes(notasComALunos);
           
            break;
        case 5:
            tamanhoFila = filaNota.queueSize();
            notasComALunos = filaNota.getNumerosNotas(tamanhoFila);

            pilhaAluno.pop(notasComALunos);
            break;
        case 6:
            filaNota.pop();
            break;
        case 7:
            if (pilhaAluno.isEmpty())
            {
                Console.WriteLine("Está vazia a pilha de Alunos");
                Console.ReadKey();
            }
            else
            {
                pilhaAluno.RunOver();
            }
            break;
        case 8:
            if (filaNota.isEmpty())
            {
                Console.WriteLine("Está vazia a Fila de Notas");
                Console.ReadKey();

            }
            else
            {
                filaNota.RunOver();
            }
            break;
        case 0:
            Console.WriteLine("volte sempre");
            break;
        default:
            Console.WriteLine("Não existe essa opção");
            break;
    }
} while (opc != 0);


