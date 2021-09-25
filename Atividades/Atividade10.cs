using System;
class Atividade10{
    static void Main(){
        int[] num1= new int[3];

        for(int i=0;i<num1.Length;i++){
        Console.Write("Digite o número na posição {0}: ",i);
        //num1[i]=Convert.ToInt16(Console.ReadLine()); 
        int.TryParse(Console.ReadLine(), out num1[i]);//segunda opção para guardar variavel em erro caso digite incorretamente.
        }

        // Verifica(num1,num2,num3);
        //SomaPar(num1);
        Maior(num1);

    }
    static void Verifica(int num1, int num2, int num3){
        int soma=num2+num3;
        if(num1 > soma){
            Console.WriteLine("O primeiro valor digitado {0} é maior que a soma de {1} + {2} = {3}",num1, num2, num3, soma);
        }else{
            Console.WriteLine("O primeiro valor digitado não é maior que a soma dos 2 últimos digitados");
        }

    }
    static void SomaPar(int[] num1){
        int guarda=0;
    
        for (int i=0; i <= num1.Length; i++){
            if(num1[i] % 2 == 0 ){
            guarda=num1[i]+guarda;  
            }          
        }
        Console.WriteLine(guarda);
    }
    static void Maior(int[] num){
        int maior=0;
        for(int i=0 ; i<num.Length;i++){
            if(num[i] > maior){
                maior=num[i];
            }
        }
        Console.WriteLine(maior);
    }
}