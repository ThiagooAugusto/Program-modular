using System;

public class Centro{
  private int x,y;

  //construtor
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
  public Circulo(int x,int y,double r):base(x,y){
    this.Raio = r;
  }

  //metodo
  public double CalculaArea(){
    return Math.PI*(Math.Pow(Raio,2));
  }
}

public class Program {
  public static void Main (string[] args) {

    //instanciar um objeto circulo
    Circulo circulo = new Circulo(10,15,4.5);

    //mostrar na tela
    circulo.CoodCentro();
    Console.WriteLine("Area: "+circulo.CalculaArea());
  }
}