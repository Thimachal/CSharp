using System;
class Aula22{
    static void Main(){
        int [] num=new int[3]{4,5,9};

        /*for(int contador=0; contador<num.Length; contador++){
            //Console.WriteLine(num[i]);
            num[contador]=0;
        }//esse for pode fazer tudo: exibir, atribuir...*/



        foreach(int n in num){//variavel n está recebendo cada variavel de num até o fim do indice
            Console.WriteLine(n);
        //foreach serve apenas para exibir
        }
}
}