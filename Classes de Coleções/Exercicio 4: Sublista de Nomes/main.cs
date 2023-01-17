using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    ArrayList usuarios = new ArrayList();
    string nome;
    int indBea,indDil;

    //preencher lista
    Console.WriteLine("----Lista de usuários----");
    Console.Write("Digite o nome do usuário ou 0 para sair:");
    nome = Console.ReadLine().ToUpper();
    while(nome != "0"){
      usuarios.Add(nome);
      Console.Write("Digite o nome do usuário ou 0 para sair:");
      nome = Console.ReadLine().ToUpper();
    }
    //ordenar em ordem alfabetica
    usuarios.Sort();

    //imprimir usuários que começam em Beatriz e terminam em Dília
    indBea = usuarios.IndexOf("BEATRIZ");
    indDil = usuarios.LastIndexOf("DÍLIA");

    if (indBea != -1 && indDil != -1){
      for (int i = indBea; i <= indDil; i++){
      Console.WriteLine(usuarios[i]);
    }
    }
     
    
  }
}