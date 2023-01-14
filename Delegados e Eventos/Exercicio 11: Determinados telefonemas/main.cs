using System;


public class Produtor{
  public delegate void RespTelefonema (object produtor, EventArgs args);
  public event RespTelefonema Telefonema;
  public void Notifica(){
    Console.WriteLine("Recebi telefonema");
    //invocar evento
    Telefonema(this, EventArgs args)
  }
}

public class Consumidor{
  public static int notificacoes = 0;
  //adicionar resposta
  public void Subscricao(Produtor p){
    p.Telefonema += new RespTelefonema(RecebiNotificacao);
  }

  public void RecebiNotificacao(object produtor, EventArgs args){
    Console.WriteLine("Recebi notificação!");
    notificacoes++;
  }
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}