using System;

// o que é sobrecarga de construtorou metodo? É simplemente ter mais uma opção de construtor e métodos. 
public class CapaContrato{//classe criada
    public int numero;
    public string objeto;
    public string cnpj;
    public int filial;

    public CapaContrato(int num, string obj, string c, int fili){//construtor 1 completo, obrigando passar como parametro todos os campos
        numero=num;
        objeto=obj;
        cnpj=c;
        filial=fili;
    }
    public CapaContrato(int num){//construtor 2 obrigando apenas 1 campo passar como parametro
        numero=num;
        objeto="campo vazio";
        cnpj="campo vazio";
        filial=0;
    }
    public void Imprime(){//metodo que imprime os obetos de acordo com os atributos preenchidos da classe
        Console.WriteLine("Número do contrato: {0}",numero);
        Console.WriteLine("Objeto do contrato {0}",objeto);
        Console.WriteLine("CNPJ: {0}",cnpj);
        Console.WriteLine("Qual a filial da nossa empresa? {0}",filial);
    }
}
class Aula30{
    static void Main(){
        CapaContrato cp1= new CapaContrato(0001,"Obras do novo CT","123647000101",0101);
        CapaContrato cp2= new CapaContrato(2);
        cp1.Imprime();
        cp2.Imprime();
    }
}