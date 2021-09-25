using System;
class Aula13{
    static void Main(){
        int n1=0, n2=0, n3=0, n4=0, res=0;
        string status="Aprovado";

        Console.Write("Digite a primeira nota: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        n4=int.Parse(Console.ReadLine());

        res=(n1+n2+n3+n4)/4;

        if (res >= 70){
            Console.WriteLine("Você está {0} e sua média {1}",status, res);
        }else if((res < 70) && (res > 50) ){
            Console.WriteLine("Você está de Recuperação e  sua média é {0}",res);
        }else {
            Console.WriteLine("Você está Reprovado e sua média é {0}",res);        
        }


}
}
