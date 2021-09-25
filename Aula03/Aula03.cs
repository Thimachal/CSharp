using System;

class Aula03{
    static void Main(){
        byte n1=10; //armazena entre 0 a 255
        int num;
        char letra = 'c';
        float valor = 5.3f;
        string nome="Thiago";
        var aux=nome;// variavel não tipada, pode ser qualquer uma

        int num1=302, num2=105;

        

        Console.WriteLine ("A multiplicação de "+ num1 + " e " + num2 + " é igual a " + num1*num2);

        Console.WriteLine(aux);

    }
}