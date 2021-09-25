using System;
/*um objeto temos que pensar em 3 coisas:
//coisas que eu tenho, ex. caneta: cor, tamanhao, ponta, carga, tampada = propriedade/atributo/variaveis
//coisas que posso fazer: escrever, rabiscar, pintar, tampar, destampar = metodo
//como estou agora: destmpada e escrevendo, tampada com nivel de x% de tinta = estado*/

public class Tv{//criei uma classe Tv
    public bool ligada=false;//propriedade da classe Tv que mostra se está ligada ou não
    public int canal=0;//propriedade da Tv que é o canal
    public int volume=30;//proprieade da Tv que é o volume
}
public class Aula28b{
    static void Main(){
        Tv TvSala= new Tv();
        Tv TvQuarto= new Tv();

        //TvSala.ligada=true;
        TvSala.canal=5;
        TvSala.volume=30;
        Console.WriteLine(TvSala.ligada);

        if (TvSala.ligada){
        Console.WriteLine("Tv Ligada");
        Console.WriteLine("estamos no canal {0}",TvSala.canal);
        Console.WriteLine("Tenha uma boa programação. O volume está em {0}",TvSala.volume);
        }else{
            Console.WriteLine ("Tv desligada, aperte o Power garoto(a)");
        }

    }
}