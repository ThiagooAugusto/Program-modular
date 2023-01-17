using System;

public interface IPessoa{
  public string NomeCompleto{
    get;
  }
  public int Idade();
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}