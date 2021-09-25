using System;
//um objeto temos que pensar em 3 coisas:

//coisas que eu tenho, ex. caneta: cor, tamanhao, ponta, carga, tampada = propriedade/atributo/variaveis
//coisas que posso fazer: escrever, rabiscar, pintar, tampar, destampar = metodo
//como estou agora: destmpada e escrevendo, tampada com nivel de x% de tinta = estado
public class Carro{//criei uma classe chamada carro
    public int velocidade=0;//proprioedade da classe Carro ou variaveis que define a velocidade
    public double temperatura=0;//proporiedade da classe Carro que define a temperatura
    public bool ligado=true;//propriedade da classe Carro que diz se está ligado ou não

}

public class Aula28{
    static void Main(){
        Carro car1= new Carro();//criando 1 objeto da classe jogador
        Carro car2= new Carro();//criando mais 1 objeto da classe jogador
        Carro car3= new Carro();//criando mais 1 objeto da classe jogador

        car1.velocidade=20;
        car1.temperatura=40.88;
        Console.WriteLine("A velocidade do carro 1 agora é: {0} km/h",car1.velocidade);
        Console.WriteLine("A temperatura do motor está em: {0}º",car1.temperatura);
        Console.WriteLine("Ele está ligado? {0}",car1.ligado);
        car1.

        Console.WriteLine("Valocidade car2: {0}",car2.velocidade);
    }
} 






   /* public void Imprime(int gas, bool lig, float Mt){

    Console.WriteLine("A gasolina está em: {0}",gas);
    Console.WriteLine("O carro está: {0}",lig);
    Console.WriteLine("A temperatura do motor agora é de {0}º",Mt);
    }*/