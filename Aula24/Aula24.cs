using System;
    class Aula24{
        static void Main(){
            Tela();
            //int numa, numb;
            int numa=Convert.ToInt32(Console.ReadLine());
            int numb=Convert.ToInt32(Console.ReadLine());
            //Multiplica(numa,numb);
            //Subtrai(numa, numb);
            //int ref=Subtrai(numa, numb);
            Console.WriteLine("Resultado da subtração de {0} e {1} é: {2}",numa, numb, Subtrai(numa,numb));
        }
        static void Tela(){
            Console.WriteLine("Thiago o melhor programador C# e ADVPL");
        }
        static void Multiplica(int num1, int num2){
            int res=num1*num2;
            Console.WriteLine("Resultado da mutiplicação de {0} e {1} é: {2}",num1, num2, res);

        }
        static int Subtrai(int num1, int num2){
            int res=num1-num2;
            return res;

        }
    }
