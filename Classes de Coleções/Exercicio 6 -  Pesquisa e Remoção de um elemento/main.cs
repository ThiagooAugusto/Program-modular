using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    //instanciar e adicionar elementos
    ArrayList localidades = new ArrayList();
    localidades.Add("Porto");
    localidades.Add("Lisboa");
    localidades.Add("Braga");
    localidades.Add("Coimbra");
     localidades.Add("Belenenses");
    

    //mostrar lista antes
    Console.WriteLine("----Lista de localidades----");
    foreach(string s in localidades){
      Console.WriteLine(s);
    }

    //remover elemnto inexistente
    RemoverLocal(localidades, "Bacalhau");

    //remover outro elemento
    RemoverLocal(localidades, "Braga");

    //mostrar
    Console.WriteLine("----Lista de localidades após remoção----");
    foreach(string s in localidades){
      Console.WriteLine(s);
    }
    
  }
  public static void RemoverLocal(ArrayList localidades, string local){
    int index;
    //fazer busca
    localidades.Sort(); 
    index  = localidades.BinarySearch(local);
    if (index < 0)
      Console.WriteLine($"local {local} não encontrado!");
    else{
      Console.WriteLine($"Removendo {local}...");
      localidades.RemoveAt(index);
    }
  }
}