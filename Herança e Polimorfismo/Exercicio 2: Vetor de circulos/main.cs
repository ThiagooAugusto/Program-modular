 using System;

public class Centro{
  private int x,y;

  //construtor
  public Centro(){
    this.x = 0;
    this.y = 0;
  }
  public Centro(int x, int y){
    this.x = x;
    this.y = y;
  }

  //metodo
  public void CoodCentro(){
    Console.WriteLine($"Coordernadas ({x},{y})");
  }

}

public class Circulo:Centro{
  private double Raio;

  //construtores
  public Circulo(){
  }
  
  public Circulo(int x,int y,double r):base(x,y){
    this.Raio = r;
  }

  //metodo
  public double CalculaArea(){
    return Math.Round(Math.PI*Math.Pow(Raio, 2), 2);
  }
}



class Program {
  public static void Main (string[] args) {
    //variaveis
    int n,x = 0,y = 0;
    double raio = 0.5;

    Console.WriteLine("Quantos circulos deseja criar: ");
    n = int.Parse(Console.ReadLine());

    //instanciar vetor de circulos
    Circulo [] vetorCirculos = new Circulo[n];

    //preencher vetor
    for (int i = 0;i <= n-1;i++){
      vetorCirculos[i] = new Circulo(x,y,raio);
       x++;y++;raio *= 2;
    }

    //Mostrar área e coordenadas
    for(int i = 0;i <= n-1;i++){
      Console.WriteLine($"Circulo {i+1}");
      vetorCirculos[i].CoodCentro();
      Console.WriteLine("Àrea do Circulo "+vetorCirculos[i].CalculaArea());
      Console.WriteLine();
    }

    
  }
}