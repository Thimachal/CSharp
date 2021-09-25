using System;
class Veiculo{
    public int rodas;
    public int velMax;
    public bool ligado;

    public void ligar(){
        ligado=true;
    }
     public void desligar(){
        ligado=false;
    }
}
class Carro:Veiculo{//herança
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}
class Aula34{
    static void Main(){

        Carro car1= new Carro("Uno Mille Way Econome","branco");
        Console.WriteLine("Está ligado? {0}",car1.ligado);
        Console.WriteLine("Quantas rodas? {0}",car1.rodas);
        Console.WriteLine("Qual o nome? {0}",car1.nome);
        Console.WriteLine("Qual a cor? {0}",car1.cor);
        Console.WriteLine("Velocidade que está? {0}",car1.velMax);
    }
}