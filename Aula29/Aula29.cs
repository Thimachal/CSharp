using System;
/*        ******Para um objeto temos que pensar em 3 coisas:******
//1º > coisa que o objeto tem, ex. caneta: cor, tamanhao da ponta, carga, tampada = propriedade/atributo/variaveis
//2º > coisas que posso fazer com o objeto: escrever, rabiscar, pintar, tampar, destampar = metodo
//3º > como o objeto está agora: destampado e escrevendo, tampada com nivel de x% de tinta = estado
*/
public class Ventilador{
    public int velocidade;
    public string cor;
    public int tamanho;
    public string tipo;
    public bool VentiOn;
    public Ventilador(string tip, string color, int tam){//aqui é construtor, quando instanciar ele já vai iniciar com todos os atributos definidos
        tipo=tip;//estou obrigando quando instanciar um objeto, tem que me dizer estas caracteristicas
        cor=color;
        tamanho=tam;
        velocidade=0;
        VentiOn=true;      
    }
}
class Aula29{
    static void Main(){
        string tipp,colorr;
        int tamm;
   
        Console.Write("Digite o tipo do ventilador: ");
        tipp=Console.ReadLine();
        Console.Write("Digite a cor do ventilador: ");
        colorr=Console.ReadLine();
        Console.Write("Digite o tamanho do ventilador: ");
        tamm=Convert.ToInt32(Console.ReadLine());

        Ventilador ven1= new Ventilador (tipp,colorr,tamm);//ao instaciar estou passando os valores do objeto da classe
    
        Console.WriteLine("Qual o modelo do ventilador a ser vendido? R= {0}",ven1.tipo);
        Console.WriteLine("Qual a cor do ventilador a ser vendido? R= {0}",ven1.cor);
        Console.WriteLine("Qual o tamanho do ventilador a ser vendido? R= {0}",ven1.tamanho);
    
    }
}