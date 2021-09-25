//PROGRAMA QUE VERIFICA SE PAR OU IMPAR
using System;
public class Atividade01{
    static void Main(){
        int numero=0;
        char opc;

        do{
            Console.WriteLine("Digite um valor: ");
            numero= int.Parse(Console.ReadLine());
            if (numero % 2 == 0){
                Console.WriteLine("Valor é par");
            }else {
                Console.WriteLine("Valor é ímpar");
            }

            Console.WriteLine("Deseja fazer uma nova operação?  S/N");
            opc=char.Parse(Console.ReadLine());

        }while(opc=='S' || opc=='s');
    Console.WriteLine("Fim do Programa Tchau!");
    }
}