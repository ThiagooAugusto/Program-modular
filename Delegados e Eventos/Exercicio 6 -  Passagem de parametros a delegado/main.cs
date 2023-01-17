using System;

public class Contentor {
  public static void Mensagens(ref string Msg, string Nova){
    Msg += Nova;
    Console.WriteLine(Msg);
  }
}
public delegate void AtualizaMensagem(ref string Msg, string Nova);

class Program {
  public static void Main (string[] args) {
    int altura = 10;
    string linha = "";

    AtualizaMensagem D = new AtualizaMensagem(Contentor.Mensagens);
    for(int i = 0; i < altura; i++){
      D(ref linha,"a");
    }
    Console.WriteLine("linha = "+linha);
  }
}