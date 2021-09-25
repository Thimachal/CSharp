using System;
class Atividade04{
    static void Main(){
        int idade;
        char opc;

        do{
        Console.Write("Insira a idade da Pessoa: ");
        idade=Convert.ToSByte(Console.ReadLine());
        Verifica(ref idade);
        
        Console.WriteLine("Deseja verificar outra idade? s/n");
        opc=Convert.ToChar(Console.ReadLine());
        }while(opc == 'S'|| opc =='s');
    Console.WriteLine("------Programa Encerrado------");
    }
    static void Verifica(ref int v){
        if(v >=18 ){
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("É de Maior Idade Pode Passar!");
            Console.ForegroundColor=ConsoleColor.White;
        }else{
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Epa, não pode de menor");
            Console.ForegroundColor=ConsoleColor.White;
        }
    }
}