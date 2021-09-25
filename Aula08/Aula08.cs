using System;
class Aula08{
    static void Main(){
    int v1, v2, soma;
    string nome;


    Console.Write("Digite o valor 1: ");
    v1=int.Parse(Console.ReadLine());//C# converte a string como inteiro
    Console.Write("Digite o valor 2: ");
    v2=Convert.ToInt32(Console.ReadLine());//2 op. para converter valor inteiro

    soma=v1+v2;

    Console.WriteLine("A soma de {0} + {1} é igual a {2}",v1, v2, soma);
    }
}