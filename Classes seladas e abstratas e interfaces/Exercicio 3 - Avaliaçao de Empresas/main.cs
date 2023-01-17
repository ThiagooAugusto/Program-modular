using System;

public abstract class AvaliacaoOrg{
  protected int codigoOrg;

  public AvaliacaoOrg(int codOrg){
    this.codigoOrg = codOrg;
  }

  //metodos
  public int ImprimeCodigo(){
    return this.codigoOrg;
  }
  public abstract double ValorOrg();
}//fim class AvaliacaoOrg

public class ONG:AvaliacaoOrg{
  //atributos de instante
  private int numeroPatrocinadores;
  private double patrocinio;
  private double custoCorrente;

  //construtor
  public ONG(int codOrg, int nPatrocinadores,double pat,double custo):base(codOrg){
    this.numeroPatrocinadores = nPatrocinadores;
    this.patrocinio = pat;
    this.custoCorrente = custo;
  }

    //calculo do valor
    public override double ValorOrg()
    {
        return (numeroPatrocinadores*patrocinio)-custoCorrente;
    }
}//fim ONG

public class Comercial:AvaliacaoOrg{
  private double proveitos;
  private double custoAno;

  public Comercial(int codOrg, double prov, double custo):base(codOrg){
    this.proveitos = prov;
    this.custoAno = custo;
  }

  //calculo do valor
  public override double ValorOrg(){
    return proveitos-custoAno;
  }
}

class Program {
  public static void Main (string[] args) {
    ONG ong = new ONG(3455,5,1500,2700);
    Console.WriteLine("ONG Codigo: "+ong.ImprimeCodigo());
    Console.WriteLine("Valor: "+ong.ValorOrg());

    Comercial comercio = new Comercial(9479,5000,3000);
    Console.WriteLine("Comercio Codigo: "+comercio.ImprimeCodigo());
    Console.WriteLine("Valor: "+comercio.ValorOrg());
    
  }
}