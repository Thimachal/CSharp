using System;
public class FuncTerc{//criei uma classe
    static public string nome;/*criado uma propriedade static, assim eu não consigo estanciar. 
    É bom quando quiser mudar para todos os objetos*/
    public string rg;
    public char sexo;
public FuncTerc(string reg, char se){//classe construtora
       
        rg=reg;
        sexo=se;
    }
public void Mostra(){//metodo para exibir os atributos do objeto criado
    Console.WriteLine("Nome do fucnionário: {0}",nome);
    Console.WriteLine("Número do RG: {0}",rg);
    Console.WriteLine("Sexo Masculino ou Feminino? {0}",sexo);
}
}
class Aula31{
    static void Main (){
        FuncTerc ft1= new FuncTerc("1234567890",'M');//novo objeto
        FuncTerc ft2= new FuncTerc("58585858",'M');
        FuncTerc.nome="Thiago Programador C# e ADVPL";/*dei um valor diretamente na propriedade, 
        assim ficará para todos que estanciar*/
        ft1.Mostra();
        ft2.Mostra();
    }
}