using System;

public delegate void CombinacaoDelegados (string x);

public class Mensagens{
  public static void Mensag1(string x){
    Console.WriteLine(x+"do primeiro método");
  }
  public static void Mensag2(string x){
    Console.WriteLine(x+"do segundo método");
  }
  public static void Mensag3(string x){
    Console.WriteLine(x+"do terceiro método");
  }
}

class Program {
  public static void Main (string[] args) {
    string s = "Olá Mundo!";
    //instanciar delegados
    CombinacaoDelegados D;
    CombinacaoDelegados D1 = new CombinacaoDelegados(Mensagens.Mensag1);
    CombinacaoDelegados D2 = new CombinacaoDelegados(Mensagens.Mensag2);
    CombinacaoDelegados D3 = new CombinacaoDelegados(Mensagens.Mensag3);
    // CombinacaoDelegados [] Del= {Mensagens.Mensag1,Mensagens.Mensag2,Mensagens.Mensag3};

    //adicionar metodos a um delegado
    D = D1 + D2 + D3;
  
    //invocar delegado
    D(s);

    //adicionar metodos a um delegado
    D -= D2;

    //invocar novamente
    D(s);
  }
}