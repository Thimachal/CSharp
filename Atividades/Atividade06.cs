using System;
class Atividade06   {
    static void Main(){
        string frase;
        Console.WriteLine("Digite alguma frase: ");
        frase=Console.ReadLine();
        SubstitueA(frase);

    }

    static void SubstitueA (string f){
        Console.WriteLine(f.Replace('A','&'));
    }
}