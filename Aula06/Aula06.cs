using System;
class Aula06{
    static void Main(){
//int n=10, u=20, m=30;
// Console.WriteLine("\n n={0}, \t u={1}, m={2}", n, u, m);
    double valorCompra=5.50;
    double valorVenda;
    double lucro=0.1;
    string produto="Tapioca";

    valorVenda=valorCompra+(valorCompra*lucro);

    Console.WriteLine("Pruduto...........:{0,10}",produto);
    Console.WriteLine("Val. Compra.......:{0,10:c}",valorCompra);
    Console.WriteLine("Lucro.............:{0,10:p}",lucro);
    Console.WriteLine("Val. Venda........:{0,10:c}",valorVenda);

    }
}