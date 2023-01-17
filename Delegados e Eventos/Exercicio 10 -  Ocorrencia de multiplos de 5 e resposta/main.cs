using System;

//delegado
public delegate void RespMultiplo5(object Produtor, EventArgs args);

//classe produtora do evento
public class Produtor{
  //evento
  public event RespMultiplo5 Multiplo5;

  //método
  public void GerarENotificar(){
    int aleat;
    Random rnd = new Random();

    for(int i = 1; i<= 50; i++){
      aleat = rnd.Next() % 100;
      //chamar evento Multiplo5 que vai executar RespMultiplo5(RecebiUmMultiplo);
      if(aleat % 5 == 0)
        Multiplo5(this,new EventArgs());
    }
  }  
}//fim Produtor

//classe consumidora
public class Consumidora{
  public static int m5 = 0;
  //adicionar resposta ao evento do produtor e ao delegado
  public void Subscricao(Produtor p){
    p.Multiplo5 += new RespMultiplo5(RecebiUmMultiplo);
  }
  //método de resposta
  public void RecebiUmMultiplo(object Produtor, EventArgs args){
    Console.WriteLine("Recebi um múltiplo de 5");
    m5++;
  }
}


class Program {
  public static void Main (string[] args) {
    Consumidora c = new Consumidora();
    Produtor p = new Produtor();

    //subscrever resposta na produtora
    c.Subscricao(p);

    //invocar evento/delegado
    p.GerarENotificar();

    //Imprimir numero de multiplos de 5
    Console.WriteLine("Recebi {0} multiplos de 5",Consumidora.m5);
  }
}