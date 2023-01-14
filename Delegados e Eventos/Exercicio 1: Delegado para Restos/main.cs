using System;


public delegate int DelegadoDeFuncoes(int x);

public class RestosDivisao{
  //metodos
  public int RestoPor2(int num){
    return num%2;
  }
    public int RestoPor3(int num){
    return num%3;
  }
}

class Program {
  public static void Main (string[] args) {
    int x = 9;
    //instanciar classe
    RestosDivisao R = new RestosDivisao();
    //instanciar o delegado
    DelegadoDeFuncoes D1 = new DelegadoDeFuncoes(R.RestoPor2);
    DelegadoDeFuncoes D2 = new DelegadoDeFuncoes(R.RestoPor3);

    //execuçao do delegado
    Console.WriteLine($"{x}%2 = "+D1(x));
    Console.WriteLine($"{x}%3 = "+D2(x));
    
  }
}