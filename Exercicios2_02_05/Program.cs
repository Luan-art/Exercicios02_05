//- []  1 - Dado duas filas p1 e p2 que armazenam números inteiros,
//faça um programa que contenha as seguintes funções:
//    - []  A) uma função que teste se duas filas são iguais,
//    caso não forem informe a maior (feito)
//    - [ ] B) uma função que fornece o maior, o menor
//    e a média aritmética entre os elementos das filas(feito)
//    - [ ] C) uma função para transferir elementos de fila
//    que eu informar para Pa        
//    - [ ] D) uma função que retorna a quantidade de elementos
//    impares de uma filas, informando quais são
//    - [ ] E) agora faça com pares


using Exercicios2_02_05;

FilaInt minhafila = new FilaInt();
FilaInt minhafila2  = new FilaInt();

int opc;

do
{
    Console.Clear();
    Console.WriteLine("Menu principal");
    Console.WriteLine("Opções");
    Console.WriteLine("1 - Inserir Valor na fila 1");
    Console.WriteLine("2 - Inserir Valor na fila 2");
    Console.WriteLine("3 - Comparar Tamanhos");
    Console.WriteLine("4 - Encontrar Maior, Menor e Média das filas");
    Console.WriteLine("5 - Copiar fila 1");
    Console.WriteLine("6 - Copiar fila 2");
    Console.WriteLine("7 - Imprimir Impares das filas");
    Console.WriteLine("8 - Imprimir Pares das filas");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Informar a opção desejada: < >\b\b");

    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            adctInteger(minhafila);
            break;
        case 2:
            adctInteger(minhafila2);
            break;
        case 3:
            int countS = minhafila.stackCounter();
            int countS2 = minhafila2.stackCounter();

            minhafila.runOver();
            Console.WriteLine();

            minhafila2.runOver();
            Console.WriteLine();

            if (countS == countS2)
            {
                Console.WriteLine("\nAs filas têm o mesmo tamanho.");
            }
            else if (countS > countS2)
            {
                Console.WriteLine("\nA fila 1 é maior.");
            }
            else
            {
                Console.WriteLine("\nA fila 2 é maior.");
            }

            Console.ReadKey();
            break;
        case 4:

            if (!minhafila.isEmpty())
            {
                minhafila.runOverHigher();
                minhafila.runOverSmallest();
                minhafila.runOverAvarage();
            }
            else
            {
                Console.WriteLine("Fila 1 Vazia");
            }

            if (!minhafila2.isEmpty())
            {
                minhafila2.runOverHigher();
                minhafila2.runOverSmallest();
                minhafila2.runOverAvarage();
            }
            else
            {
                Console.WriteLine("Fila 2 Vazia");
            }
            break;
        case 5:
            if (!minhafila.isEmpty())
            {
                Console.WriteLine("Fila 1:");
                minhafila.runOver();
                FilaInt pilhaCopia = minhafila.copyStack();
                Console.WriteLine("Fila Copia:");
                pilhaCopia.runOver();

            }
            else
            {
                Console.WriteLine("Fila 1 Vazia");
            }
            break;
        case 6:
            if (!minhafila2.isEmpty())
            {
                Console.WriteLine("Fila 2:");
                minhafila2.runOver();
                FilaInt pilhaCopia = minhafila2.copyStack();
                Console.WriteLine("Fila Copia:");
                pilhaCopia.runOver();

            }
            else
            {
                Console.WriteLine("Fila 2 Vazia");
            }
            break;
        case 7:
            if (!minhafila.isEmpty())
            {
                minhafila.runOverOdd();
            }
            else
            {
                Console.WriteLine("Fila 1 está vaiza");
            }

            if (!minhafila2.isEmpty())
            {
                minhafila2.runOverOdd();
            }
            else
            {
                Console.WriteLine("Fila 2 está vaiza");
            }
            break;
        case 8:
            if (!minhafila.isEmpty())
            {
                minhafila.runOverEven();
            }
            else
            {
                Console.WriteLine("Fila 1 está vaiza");
            }

            if (!minhafila2.isEmpty())
            {
                minhafila2.runOverEven();
            }
            else
            {
                Console.WriteLine("Fila 2 está vaiza");
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

void adctInteger(FilaInt minhaPilha)
{
    int n;
    Console.WriteLine("Informe um número: ");
    n = int.Parse(Console.ReadLine());
    Inteiro inteiro = new Inteiro(n);
    minhaPilha.push(inteiro);
}