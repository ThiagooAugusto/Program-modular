using System;

public abstract class Estrada{
  protected string designacao;
  protected int limiteMaximo;
  protected int limiteMinimo;

  //construtores
  public Estrada(string dEstrada, int limMax,int limMin){
    this.designacao = dEstrada;
    this.limiteMaximo = limMax;
    this.limiteMinimo = limMin;
  }

  //metodos
  public abstract string LerDesig();
  public abstract int LerVelocidadeMax();
  public abstract int LerVelocidadeMin();
}//fim class Estrada

public class AutoEstrada:Estrada{
  //construtor
  public AutoEstrada(string dEstrada, int limMax, int limMin):base(dEstrada,limMax,limMin){
    
  }

  //metodos
  public override string LerDesig(){
    return this.designacao;
  }
  
  public override int LerVelocidadeMax(){
    return  this.limiteMaximo;
  }

  public override int LerVelocidadeMin(){
    return this.limiteMinimo;
  }
}

class Program {
  public static void Main (string[] args) {
    AutoEstrada autoEstrada = new AutoEstrada("Auto Bahn",220,40);
    //Estrada estrada = new Estrada("Estrada real",180,30); nao podemos instanciar classes abstratas

    Console.WriteLine("Estrada: "+autoEstrada.LerDesig());
    Console.WriteLine("Velocidade Maxima: "+autoEstrada.LerVelocidadeMax());
    Console.WriteLine("Velocidade Minima: "+autoEstrada.LerVelocidadeMin());
  }
}