using System;

public class Multiplos{
  //metodos
  public static int Dobro(int x){
    return x * 2;
  }
   public static int Triplo(int x){
    return x * 3;
  }
  public static int Quadruplo(int x){
    return x * 4;
  }
  
}

public delegate int DelegadoFuncoes(int x);

class Program {
  public static void Main (string[] args) {
    int num = 5;
    int soma = 0;
    //instanciar vetor de delegados
    DelegadoFuncoes [] D = {Multiplos.Dobro,Multiplos.Triplo,Multiplos.Quadruplo};

    Console.WriteLine("dobro, triplo,e quadruplo de 5: ");

    //invocar os delegados
    for(int i = 0; i < D.Length;i++){
      Console.WriteLine(D[i](num));
      soma = soma + D[i](num);
    }

    //imprimir soma
    Console.WriteLine("A soma das tres funcoes é "+soma);
  }
}