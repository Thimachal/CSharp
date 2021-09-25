using System;
class Aula12{
static void Main(){
    int n1=0, n2=0, n3=0, n4=0, res=0;
    string status="Aprovado";

    Console.WriteLine("Digite a primeira nota: ");
    n1=int.Parse(Console.ReadLine());

    Console.WriteLine("Digite as segunda nota: ");
    n2=int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a terceira nota: ");
    n3=int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quarta nota: ");
    n4=int.Parse(Console.ReadLine());

    res=(n1+n2+n3+n4)/4;

if (res>=70){

    Console.WriteLine("Sua média é {0} e está {1}", res, status);
}else{
    Console.WriteLine("Sua media é {0} e está Reprovado",res);
}


}

}