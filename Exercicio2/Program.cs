// See https://aka.ms/new-console-template for more information
//EXERCICIO 2

Console.WriteLine("Escreva o seu nome: ");
string nomeUsuario;
nomeUsuario = Console.ReadLine();
Console.WriteLine("Escreva a sua idade: ");
int idade;
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escreva a sua altura: ");
double altura;
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escreva o seu peso: ");
double peso;
peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Nome: " + nomeUsuario + ", idade: " + idade.ToString() + ", altura: " + altura.ToString() + ", peso: " + peso.ToString());