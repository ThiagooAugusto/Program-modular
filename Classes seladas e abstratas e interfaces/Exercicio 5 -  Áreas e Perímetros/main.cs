using System;

public interface IMedidas{
  public double Area();
  public double Perimetro();
}

public class Quadrado:IMedidas{
  //atributos
  private double lado;

  //construtor
  public Quadrado(double l){
    this.lado = l;
  }

  //métodos Area e Perimetro
  public double Area(){
    return lado*lado;
  }

  public double Perimetro(){
    return 4*lado;
  }
  
}//fim Quadrado

public class Triangulo:IMedidas{
  //atributos
  private double Base;
  private double Altura;
  private string Tipo;

  //construtor
  public Triangulo(double B,double A,string T){
    this.Base = B;
    this.Altura = A;
    this.Tipo = T;
  }

  //metodos 
  public double Area(){
    return (Base*Altura)/2;
  }
  public double Perimetro(){
    double p,hip;

    switch(Tipo){
      case "Isosceles":
        hip = Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Base/2,2));
        p = Base + 2*hip;
        break;
      case "Equilatero":
        p = 3 * Base;
        break;
      default:
        p = Base + (Base + 1) + (Base + 2);
        break;
    }
    return p;
  }
  
}//fim Triangulo

class Program {
  public static void Main (string[] args) {
    Quadrado quadrado1 = new Quadrado(3);
    Triangulo triangulo1 = new Triangulo(3,3,"Equilatero");
    Triangulo triangulo2 = new Triangulo(12,8,"Isosceles");

    Console.WriteLine($"Perimetro quadrado:{quadrado1.Perimetro()} Area quadrado:{quadrado1.Area()}");
    Console.WriteLine($"Triangulo Equilatero - Perimetro: {triangulo1.Perimetro()} Area:{triangulo1.Area()}");
      Console.WriteLine($"Triangulo Isosceles Perimetro: {triangulo2.Perimetro()} Area:{triangulo2.Area()}");
  }
}