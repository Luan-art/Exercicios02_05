// Faça um programa que coloque os N valores da sequencia Fibonnaci em uma Fila

using Exercicios4_02_05;

int posicaoMaxima = 0, atual = 0, penultimo = 0, ultimo = 1, auxiliar = 0;

FilaInt minhaPilha = new FilaInt();

do
{
    Console.WriteLine("Digite uma posição para chegarmos na sequência Fibonacci:");
    posicaoMaxima = int.Parse(Console.ReadLine());
} while (posicaoMaxima <= 0);

Console.WriteLine("Fibonacci até a posição " + posicaoMaxima);

for (int i = 0; i < posicaoMaxima; i++)
{
    Inteiro inteiro = new Inteiro(atual);
    minhaPilha.push(inteiro);
    auxiliar = atual;
    atual = ultimo;
    ultimo = auxiliar + ultimo;
}

minhaPilha.runOver();