using System;
class Aula25{
    static void Main(){
        int num=10;

        Dobrar(ref num); 
       /* Console.WriteLine(num);
       Passagem por referência a variavel enviada (ex. ponteiro) é alterada na memória
       Passagem por valor apenas o valor que contém nela é enviado 
       para o metodo para executar dentro dele*/

    }
    static void Dobrar(ref int valor){
        valor*=2;
        Console.WriteLine(valor);
    }

}