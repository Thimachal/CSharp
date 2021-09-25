using System;
class Service{
    public int qtd;
    public bool status;
    public void Inativo(){
       status=false;
    }
    public void Ativo(){
       status=true;
    }
    public string getAtivo(){
        if(status==true){
            return "sim";
        }else{
            return "não";
        }
    }
    
}
class Contrato:Service{
    public string nomeEmp;
    public string cnpj;

    public Contrato(string nomeemp, string CNPJ){
        Ativo();
        this.nomeEmp=nomeemp;
        this.cnpj=CNPJ;
        qtd=1;
    }

}
class Aula34a{
    static void Main(){
        Contrato c1= new Contrato("Thimachal LTDA","13962799000103");
        Console.WriteLine("Nome da Empresa: {0}",c1.nomeEmp);
        Console.WriteLine("CNPJ: {0}",c1.cnpj);
        Console.WriteLine(c1.getAtivo());
        Console.WriteLine(c1.qtd);
    }
}