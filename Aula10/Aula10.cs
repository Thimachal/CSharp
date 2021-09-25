using System;
class Aula10{
    enum MesAno{Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro}

static void Main (){
    
    //MesAno m1 = MesAno.Janeiro;//determino qual mês aparecer/apontar
    //MesAno m2 = (MesAno)5; //pela posição digo qual mês exibir/apontar
    //int m3 = (int)MesAno.Agosto;//exibe qual o num. da posição do mês
    //Console.WriteLine(m1);
    //Console.WriteLine(m2);
   // Console.WriteLine(m3);
    MesAno m;
    int contador=0;

    for(contador=0 ; contador < m.Length ; contador++ ){
        Console.WriteLine(m[contador]);

    }


}
}