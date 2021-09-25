using System;
class Atividade05{
    static void Main(){
        string nome="Thiago desenvolvedor em C# e ADVPL";
        MostraNome(nome);  

    }
    static void  MostraNome(string n){
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.WriteLine("Olá meu nome é {0}",n);
        Console.ForegroundColor=ConsoleColor.Yellow;
    }
}