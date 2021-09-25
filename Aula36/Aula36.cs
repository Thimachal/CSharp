using System;

class Aviao{
    public int vAtual;
    private int vMax;
    protected bool ligado;

    public Aviao(int vMax){
        vAtual=100;
        this.vMax=vMax;
    }
}
class Jatinho:Aviao{
    public string nome;
    public Jatinho(string name, int veloMax):base (veloMax){
        this.nome=name;
        ligado=true;
    }
}

class Aula36{
    static void Main(){
        Jatinho j1=new Jatinho("Devoinmant",160);
        Console.WriteLine(j1.nome);
        Console.WriteLine(j1.ligado);
    }
}