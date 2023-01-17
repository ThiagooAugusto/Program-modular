using System;

public class ParDeObjetos{
  public delegate int Ordenar(object a, object b);

  //atributos
  private object [] oPar = new object[2];

  //construtor
  public ParDeObjetos(object a, object b){
    oPar[0] = a;
    oPar[1] = b;
  }

  
  //métodos
  public void Ordem(Ordenar FuncaoDel){
    object temporario = new object();
    if (FuncaoDel(oPar[0],oPar[1])== 2){
      temporario = oPar[0];
      oPar[0] = oPar[1];
      oPar[1] = temporario;
    }
  }
  public override string ToString( ){
    return oPar[0].ToString() + " e " + oPar[1].ToString();
  }
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}