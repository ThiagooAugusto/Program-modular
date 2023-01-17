using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    ArrayList utentes = new ArrayList();
    string nome;

    //Ler nome
    Console.Write("Digite nome do utente ou 0 para sair: ");
    nome = Console.ReadLine();
    while(nome != "0"){
      utentes.Add(nome);
      Console.Write("Digite nome do utente ou 0 para sair: ");
      nome = Console.ReadLine();
    }
    utentes.Sort();
    Console.WriteLine("Lista utentes");
    foreach(string s in utentes){
      Console.WriteLine(s);
    }
    
  }
}