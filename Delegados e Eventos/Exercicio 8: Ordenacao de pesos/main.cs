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

public class Gato{
  private int peso;

  public Gato(int p){
    peso = p;
  }

  public static int OrdemPesos(object a, object b){
    //converter objeto no tipo Gato
    Gato G1 = (Gato)a;
    Gato G2 = (Gato)b;
    return (G1.peso < G2.peso ? 1 : 2);
  }
    public override string ToString()
    {
       return peso.ToString() + "kg";
    }
}

class Program {
  public static void Main (string[] args) {
    Gato G1 = new Gato(20);
    Gato G2 = new Gato(15);
    ParDeObjetos pares = new ParDeObjetos(G1,G2);
    
    //instanciar o delegado
    ParDeObjetos.Ordenar delegado = new ParDeObjetos.Ordenar(Gato.OrdemPesos);
    
    //invocar o método para ordenar
    pares.Ordem(delegado);

    //mostrar na tela
    Console.WriteLine(pares.ToString());
    
  }
}
