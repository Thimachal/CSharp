using System;
class Atividade07{
    static void Main(){
        float salario=0, novosalario=0;

        Console.Write("Qual o valor do salário atual? ");
        salario=float.Parse(Console.ReadLine());
        novosalario=CalcSalario(ref salario);

        Console.WriteLine("O salário era de {0} e foi para {1} após o reajuste.", salario, novosalario);

    }
   static float CalcSalario(ref float real){
            float novosal=0;
            if(real < 1700){
                novosal=real+300;
            }else{
                novosal=real+900;
            }return novosal;
    }
}