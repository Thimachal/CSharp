using System;
class Aula20{
    static void Main(){
        
        int[] numeros=new int[8];
        int contador=numeros.Length-1;

        while (contador>=0){
            numeros[contador]=0;
            Console.WriteLine(numeros[contador]);
            contador--;

        }

        Console.WriteLine("Fim do Programa, tchau!!");
    }
}