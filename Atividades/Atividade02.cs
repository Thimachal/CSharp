using System;
using System.Globalization;
class Atividade02{
        static void Main(){
        
        string nome;
        char opc;
        do{
            Console.Write("Digite aqui seu nome: ");
            nome=Console.ReadLine();
            Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome));
            Console.WriteLine("Deseja continuar a operação? s/n");
            opc=Convert.ToChar(Console.ReadLine());

        }while (opc == 'S' || opc =='s');
        Console.WriteLine("Fim do programa tchau");
    }
}