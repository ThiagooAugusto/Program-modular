using System;

public delegate int DelegadoParaComposicao(int x);

public class ContentorDeFuncoes{
  public static int Dobro (int x){
    return x*2;
  }

  public static int Triplo (int x){
    return x*3;
  }
}

class Program {
  public static void Main (string[] args) {
    DelegadoParaComposicao [] D = {ContentorDeFuncoes.Triplo,ContentorDeFuncoes.Dobro};

    int x = 5;
    Console.WriteLine("Triplo do dobro de {0} = {1}",x,D[0](D[1](x)));
  }
}