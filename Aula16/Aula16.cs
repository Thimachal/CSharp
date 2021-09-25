using System;
class Aula15{
static void Main(){
    int tempo=0;
    char e, escolha;
    double price=0;
    
    inicio:

    Console.Clear();

    Console.WriteLine("Escolha a sua viagem\n-----  [a] Avião [c] Carro [f] FerryBoat  -----");
    e=char.Parse(Console.ReadLine());

    switch (e){
        case 'a':
        case 'A':
            tempo=60;
            price=800.95;
            break;
        case 'c':
        case 'C':
            tempo=280;
            price=360.50;
            break;
        case 'f':
        case 'F':
            tempo=180;
            price=120.70;
            break;
        default:
            tempo=-1;
            break;
    }
    tempo=tempo/60;
    if(tempo<0){
        Console.WriteLine("Resposta Inválida, tente novamente");
    }else{
        Console.WriteLine("Passagem Escolhida! Tempo da viagem é de {1}h e o valor da passagem: {2:c}", e, tempo, price);
    }
    Console.WriteLine("Deseja comprar nova passagem? s / n");
    escolha=char.Parse(Console.ReadLine());
    if(escolha=='S' || escolha =='s'){
        goto inicio;
    }
}
}