using System;
class Aula19{
    static void Main(){
        int [] num=new int [10];
        

        for(int contador=0 ; contador<num.Length; contador++){
            num[contador]=contador;
            Console.WriteLine("Valor de num na posição {0}: {1} ",contador, num[contador]);

        }
}
}