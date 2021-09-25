using System;

public class Calculo{
    public int v1;
    public int v2;

    public Calculo(int v1, int v2){
        this.v1=v1;//o this seta dizendo que o v1 da classe vai receber o v1 como parametro do construtor
        this.v2=v2;//this vai sempre referencia a proporiedade pai/classe
    }
    public int Soma(){
        return v1+v2;
    }

}

class Aula32{
    static void Main(){
        Calculo c1= new Calculo(10,5);
        Console.WriteLine(c1.Soma());
    }
}