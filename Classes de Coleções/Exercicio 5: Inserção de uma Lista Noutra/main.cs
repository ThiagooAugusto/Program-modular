using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    //inicializar listas
   string [] f = new string[5]{"Maçã","Laranja","Pera","Cereja","Tangerina"};
    string [] fT = new string[4]{"Banana","Papaia","Anona","Manga"};
    
    ArrayList frutos = new ArrayList();
    ArrayList frutosTropicais = new ArrayList();

    //preencher listas dinamicas
    foreach(string s in f){
      frutos.Add(s);
    }
     foreach(string s in fT){
      frutosTropicais.Add(s);
    }

    //inserir elementos de frutosTropicais em frutos
    frutos.InsertRange(frutos.Count,frutosTropicais);
    
    //ordenar alfabeticamente
    frutos.Sort();

    //imprimir numero de frutos
    Console.WriteLine("O numero de frutos da lista é "+frutos.Count);
    
    
  }
}