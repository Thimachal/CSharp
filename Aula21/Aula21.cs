using System;
class Aula21{
    static void Main(){
        string senha="thima", senhaadm;
        int tentativas=0;

        do{
            Console.WriteLine("---Digite a senha: ");
            senhaadm=Console.ReadLine();
            tentativas++;

        }while((senha!=senhaadm) && (tentativas < 5));
        if(tentativas >= 5){
            Console.WriteLine("Tentativas esgotadas, procure o ADM Thiago no setor de T.I");
        }else{
            Console.WriteLine("Senha correta, seja bem vindo! (tentativas: {0})",tentativas);
        }
    }
}