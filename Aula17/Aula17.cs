using System;
class Aula17{
    static void Main(){
        int [] n1=new int[5];//1 forma de declara vetor
        int [] n2=new int[2]{40,50};//2 forma de declara vetor
        int [] n3={47,55,41,559};//3 forma. automaticamente ele entende como vetor de 4posições
        string [] v= new string[3]{"Moto, Avião, Ferry"};//uma forma de declarar string
        string [] vs= new string[3];//outra forma de declarar string


        vs[0]="Carro";
        vs[1]="Avião";
        vs[2]="Ferry";
        Console.WriteLine(vs[0]);

    }

}