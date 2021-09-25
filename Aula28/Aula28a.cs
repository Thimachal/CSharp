using System;
/*
            ******Para um objeto temos que pensar em 3 coisas:******

//1º > coisa que o objeto tem, ex. caneta: cor, tamanhao da ponta, carga, tampada = propriedade/atributo/variaveis
//2º > coisas que posso fazer com o objeto: escrever, rabiscar, pintar, tampar, destampar = metodo
//3º > como o objeto está agora: destampado e escrevendo, tampada com nivel de x% de tinta = estado

*/
public class Caneta{//parte 1º definida,o que o objeto tem?
    string modelo;
    string cor;
    double ponta=0.7;
    int carga=100;
    bool tampada;//tampada? sim, veja que isso foi configurado no metodo logo abaixo

}
class Aula28a{
    static void Main(){
        Caneta pencil1= new Caneta();//criamos um novo objeto, ou seja, estanciamos uma classe em forma de um objeto
    }
}