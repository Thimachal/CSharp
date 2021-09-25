using System;
class Atividade09{
    static void Main(){
    float A, b, h;

    Console.WriteLine("----Programa que Calcula a Area do Retângulo----\n\n");

    Console.Write("Digite o valor da base: ");
    b=float.Parse(Console.ReadLine());
    
    Console.Write("Digite o valor da altura: ");
    h=float.Parse(Console.ReadLine());

    A=RetanguloCalcArea(b,h);
    Console.WriteLine("Com a base no valor de {0} e altura {1} a área do retângulo é: {2}",b,h,A);
    }
    static float RetanguloCalcArea(float b, float h){
        float A=0;
        return A=b*h;
    }

}