using System;
class Atividade03{
    static void Main(){
        int numero1=0,numero2=0;
        char opc1;
        sbyte opc2;

        Console.WriteLine("-----CALCULADORA DO THIMACHAL-----");
       do{ 
        Console.Write("Digite o primeiro valor: ");
        numero1=Convert.ToInt16(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        numero2=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Escolha a operação: [1] SOMA [2] SUBTRAÇÃO [3] MULTIPLICAÇÃO [4] DIVISÃO");
        opc2=Convert.ToSByte(Console.ReadLine());
        switch(opc2){
            case 1:
            Console.WriteLine("A soma de {0} com {1} é: {2}",numero1, numero2,numero1+numero2);
            break;
            case 2:
            Console.WriteLine("A subtração de {0} com {1} é: {2}",numero1, numero2,numero1-numero2);
            break;
            case 3:
            Console.WriteLine("A multiplicação de {0} com {1} é: {2}",numero1, numero2,numero1*numero2);
            break;
            case 4:
            Console.WriteLine("A divisão de {0} com {1} é: {2}",numero1, numero2,numero1/numero2);
            break;
        }
        Console.WriteLine("Deseja fazer outra operação? s/ n");
        opc1=Convert.ToChar(Console.ReadLine());
    } while(opc1 == 'S' || opc1 == 's');
    }
}