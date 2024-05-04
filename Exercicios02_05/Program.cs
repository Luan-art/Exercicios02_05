//- []  1 - Dado duas pilhas p1 e p2 que armazenam números inteiros,
//faça um programa que contenha as seguintes funções:
//    - []  A) uma função que teste se duas pilhas são iguais,
//    caso não forem informe a maior (feito)
//    - [ ] B) uma função que fornece o maior, o menor
//    e a média aritmética entre os elementos das pilhas(feito)
//    - [ ] C) uma função para transferir elementos de pilha
//    que eu informar para Pa        
//    - [ ] D) uma função que retorna a quantidade de elementos
//    impares de uma pilhar, informando quais são
//    - [ ] E) agora faça com pares


using Exercicios02_05;

PilhaInt minhapilha = new PilhaInt();
PilhaInt minhapilha2 = new PilhaInt();

int opc;

do
{
    Console.Clear();
    Console.WriteLine("Menu principal");
    Console.WriteLine("Opções");
    Console.WriteLine("1 - Inserir Valor na pilha 1");
    Console.WriteLine("2 - Inserir Valor na pilha 2");
    Console.WriteLine("3 - Comparar Tamanhos");
    Console.WriteLine("4 - Encontrar Maior, Menor e Média das Pilhas");
    Console.WriteLine("5 - Copiar Pilha 1");
    Console.WriteLine("6 - Copiar Pilha 2");
    Console.WriteLine("7 - Imprimir Impares das Pilhas");
    Console.WriteLine("8 - Imprimir Pares das Pilhas");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Informar a opção desejada: < >\b\b");

    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            adctInteger(minhapilha);
            break;
        case 2:
            adctInteger(minhapilha2);
            break;
        case 3:
            int countS = minhapilha.stackCounter();
            int countS2 = minhapilha2.stackCounter();
            Console.WriteLine();

            minhapilha.runOver();
            Console.WriteLine();

            minhapilha2.runOver();
            Console.WriteLine();

            if (countS == countS2)
            {
                Console.WriteLine("\nAs pilhas têm o mesmo tamanho.");
            }
            else if (countS > countS2)
            {
                Console.WriteLine("\nA pilha 1 é maior.");
            }
            else
            {
                Console.WriteLine("\nA pilha 2 é maior.");
            }

            Console.ReadKey();
            break;
        case 4:

            if (!minhapilha.isEmpty())
            {
                minhapilha.runOverHigher();
                minhapilha.runOverSmallest();
                minhapilha.runOverAvarage();
            }
            else
            {
                Console.WriteLine("Pilha 1 Vazia");
            }

            if (!minhapilha2.isEmpty())
            {
                minhapilha2.runOverHigher();
                minhapilha2.runOverSmallest();
                minhapilha2.runOverAvarage();
            }
            else
            {
                Console.WriteLine("Pilha 2 Vazia");
            }
            break;
        case 5:
            if (!minhapilha.isEmpty())
            {
                Console.WriteLine("Pilha 1:");
                minhapilha.runOver();
                PilhaInt pilhaCopia = minhapilha.copyStack();
                Console.WriteLine("Pilha Copia:");
                pilhaCopia.runOver();

            }
            else
            {
                Console.WriteLine("Pilha 1 Vazia");
            }
            break;
        case 6:
            if (!minhapilha2.isEmpty())
            {
                Console.WriteLine("Pilha 2:");
                minhapilha2.runOver();
                PilhaInt pilhaCopia = minhapilha2.copyStack();
                Console.WriteLine("Pilha Copia:");
                pilhaCopia.runOver();

            }
            else
            {
                Console.WriteLine("Pilha 2 Vazia");
            }
            break;
        case 7:
            if (!minhapilha.isEmpty())
            {
                minhapilha.runOverOdd();
            }
            else
            {
                Console.WriteLine("Pilha 1 está vaiza");
            }

            if (!minhapilha2.isEmpty()) 
            {
                minhapilha2.runOverOdd();
            }
            else
            {
                Console.WriteLine("Pilha 2 está vaiza");
            }
            break;
    case 8:
            if (!minhapilha.isEmpty())
            {
                minhapilha.runOverEven();
            }
            else
            {
                Console.WriteLine("Pilha 1 está vaiza");
            }

            if (!minhapilha2.isEmpty())
            {
                minhapilha2.runOverEven();
            }
            else
            {
                Console.WriteLine("Pilha 2 está vaiza");
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

void adctInteger(PilhaInt minhaPilha)
{
    int n;
    Console.WriteLine("Informe um número: ");
    n = int.Parse(Console.ReadLine());
    Inteiro inteiro = new Inteiro(n);
    minhaPilha.push(inteiro);
}