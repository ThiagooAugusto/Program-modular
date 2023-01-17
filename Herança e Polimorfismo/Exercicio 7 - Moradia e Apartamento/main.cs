using System;

public class Propriedade {
  private string proprietario;
  private int numeroFiscal;

  //construtores
  public Propriedade(string nome,int nf){
    this.proprietario = nome;
    this.numeroFiscal = nf;
  }


  //metodo para calcular renda minima
  public int RendaMinima(double area){
    double renda;
    const double P1 = 0.20;
    const double P2 = 0.30;
    if (area < 50){
      renda = 100;
    }
    else if(area < 100){
      renda = 100 + P1 * area;
    }
    else{
      renda = 100 + P2 * area;
    } 
    return (int)Math.Round(renda,0);
  }

  //metodo para imprimir na tela
  public override string ToString(){
    return proprietario + "-----"+ numeroFiscal;
  }
}//fim classe propriedade

public class Moradia:Propriedade{
  private string local;
  private char categoria;

  //construtor
  public Moradia(string nome,int nf,string loc):base(nome,nf){
    this.local = loc;
    TipoCategoria(loc);
  }

  //metodos
  //determina tipo categoria em função do local
  public void TipoCategoria(string local){
    switch(local){
        case "Lisboa":
          this.categoria = 'A';
        break;
        case "Porto":
          this.categoria = 'B';
        break;
        case "Coimbra":
          this.categoria = 'C';
        break;
        case "Braga":
          this.categoria = 'D';
        break;
      default: Console.WriteLine("Cidade não reconhecida!");
        break;
    }
  }
  //determina renda mensal em função da categoria
  public int RendaMensal (char categoria){
    int renda = 0;
    switch(categoria){
      case 'A':
        renda = 1000;
        break;
      case 'B':
        renda = 1000;
        break;
      case 'C':
        renda = 600;
        break;
      case 'D':
        renda = 450;
        break;
    }
    return renda;
  }
}//fim Moradia

public class Apartamento:Propriedade{
  private string tipo;
  private double area;

  public Apartamento(string nome, int nf,string tipo, double area):base(nome,nf){
    this.tipo = tipo;
    this.area = area;
  }

  //acessor
  public double LerArea(){
    return this.area;
  }
}

class Program {
  public static void Main (string[] args) {
    //imprimir valor de renda mínima
    //instanciar objeto
    Apartamento apto = new Apartamento("Thiago Augusto",1125,"T2",98);
    Moradia M = new Moradia("Mercia maria",4456,"Lisboa")

    Console.WriteLine(apto.ToString());
    Console.WriteLine("Renda minima: "+apto.RendaMinima(98));
  }
}