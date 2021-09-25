using System;
class Atividade08{
    static void Main(){
        int numero;
        char opc;

        do{
            Console.Write("Qual valor desej aver sua tabuada? Digite aqui: ");
            numero=Convert.ToInt32(Console.ReadLine());

            Tabuada(numero);
            
            Console.WriteLine("Deseja continuar com outro valor? s/n");
            opc=Convert.ToChar(Console.ReadLine());
        }while(opc == 'S'|| opc == 's');

        Console.WriteLine("Fim de Programa, tchau cabeça!");   
        }
    static void Tabuada(int n){

        for(int cont=1 ; cont <= 10 ; cont++){
            int res=0;
            res=n+cont; 
            Console.WriteLine("{0} + {1} = {2}", n, cont, res);
            
        }
        
        for(int cont=1 ; cont <= 10 ; cont++){
            int res=0;
            res=n-cont; 
            Console.WriteLine("{0} - {1} = {2}", n, cont, res);
            
        }
        for(int cont=1 ; cont <= 10 ; cont++){
            int res=0;
            res=n*cont; 
            Console.WriteLine("{0} * {1} = {2}", n, cont, res);
            
        }
        for(int cont=1 ; cont <= 10 ; cont++){
            int res=0;
            res=n/cont; 
            Console.WriteLine("{0} / {1} = {2}", n, cont, res);
            
        }
    }

}