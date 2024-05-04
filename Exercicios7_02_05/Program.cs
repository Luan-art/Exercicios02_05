//7-Crie uma classe chamada PESSSOA (Nome, Idade, Profissão),
//além dos métodos padrões, crie um método para calcular a idade
//em anos bissextos  

using Exercicios7_02_05;
int opc;

Console.WriteLine("Digitar o nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Digitar sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digitar se profissão: ");
string profissao = Console.ReadLine();

Pessoa pessoa = new Pessoa(nome, idade, profissao);

Console.WriteLine(pessoa.ToString()); 

Console.WriteLine("Idade em anos Bissextos " + pessoa.IdadeEmBissexto() + " em anos bissextos");
