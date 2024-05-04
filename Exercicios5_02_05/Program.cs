// - [ ]  5-Cadaste 10 números em uma fila dinâmica e outros 10 em uma fila dinamica
// ( sortear, podem ser repetidos na fila e na pilha), em seguida mostre os 3 relatórios
//- []  A) Números iguais em ambas estruturas
//- [ ] B) Os que estão na fila
//- [ ] C) Os que estão nas pilhas

using Exercicios5_02_05;
int max = 10, contador = 0;

int[] numerosPilha = new int[max];
int[] numerosFila = new int[max];
int[] numerosNasDuas = new int[max];

FilaInt minhafila = new FilaInt();
PilhaInt minhapilha = new PilhaInt();

PreencherFila(minhafila);
PreencherPilha(minhapilha);

numerosPilha = minhapilha.runOverNumbers();

numerosFila = minhafila.runOverNumbers();

Console.WriteLine("Fila 1: ");
minhafila.runOver();

Console.WriteLine("Pilha 2: ");
minhapilha.runOver();

Console.WriteLine("Numero Iguais: ");

for (int i = 0; i < max; i++)
{
    for (int j = 0; j < max; j++)
    {
        if (numerosFila[i] == numerosPilha[j])
        {
            numerosNasDuas[contador] = numerosFila[i];
            contador++;
        }
    }
}

for (int i  = 0; i < contador; i++)
{
    Console.WriteLine(numerosNasDuas[i]);
}

void PreencherFila(FilaInt minhaFila)
{
    for (int i = 0; i <= max; i++)
    {
        Inteiro inteiro = new Inteiro(new Random().Next(1, 50));
        minhaFila.push(inteiro);

    }
}

void PreencherPilha(PilhaInt minhaPila)
{
    for (int i = 0; i <= max; i++)
    {
        Inteiro inteiro = new Inteiro(new Random().Next(1, 50));
        minhaPila.push(inteiro);

    }
}