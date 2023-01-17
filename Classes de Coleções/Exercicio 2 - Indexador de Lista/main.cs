using System;

public class MaterialEscolar{
  //atributos
  private string dono;
  private string [] material;
  private int ultimoIndice = 0;

  //construtor
  public MaterialEscolar(string nome, params string[] descricao){
    this.dono = nome;
    material = new string[10];
    //preencher vetor 
    foreach(string s in descricao){
      material[ultimoIndice++] = s;
    }
  }

  //acessores
  public string Dono{
    get{
      return this.dono;
    }
  }

  public int Posicao{
    get{
      return this.ultimoIndice;
    } 
  }

  //indexador
  public string this[int i]{
    get{
      try{
        return material[i];
      }
      catch{
        return "Erro! Indice é menor que zero ou excede tamanho da lista";
      }
    }
    set{
      try{
         material[i] = value;
         if(ultimoIndice < i + 1){
        ultimoIndice= i;
      }
      }
      catch{
       Console.WriteLine("Erro! Indice é menor que zero ou excede tamanho da lista");
      }
     
    }
  }
}

class Program {
  public static void Main (string[] args) {
    MaterialEscolar listaM= new MaterialEscolar("joao","caderno","caneta","lapiseira","borracha","calculadora");

    //retornar elemento
    Console.WriteLine("Elemento na posicao 4: "+listaM[4]);
    listaM[5] = "cola";
    Console.WriteLine("Elemento na posicao 5: "+listaM[5]);

    //Inserir elemento
    listaM[6]="régua";
    Console.WriteLine("Elemento na posicao 6: "+listaM[6]);

    listaM[10]="dicionario";
    Console.WriteLine("Elemento na posicao 10: "+listaM[10]);
    
    
  }
}