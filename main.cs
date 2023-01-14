using System;

public class Pasta{
  //só pode ser acessado por classes filhas
  protected string designacao;

  //construtores
  public Pasta(string desig){
    this.designacao = desig;
  }
}//fim Pasta

public class SubPasta:Pasta{
  protected string subDesignacao;

  public SubPasta (string desig,string subDesig):base(desig){
    this.subDesignacao = subDesig;
  }
}//fim Subpasta

public sealed class SubSubPasta:SubPasta{
  private string subSubDesignacao;

  public SubSubPasta(string desig,string subDesig,string subSubDesig):base(desig,subDesig){
    this.subSubDesignacao = subSubDesig;
  }

  public string ImprimeCaminho(){
    return "Caminho: "+base.designacao+ "/" +base.subDesignacao+ "/" +this.subSubDesignacao;
  }
}//fim SubSubPasta

class Program {
  public static void Main (string[] args) {
    SubSubPasta subSubPasta1 = new SubSubPasta("Praticas C#","Classe abstratas,seladas e interfaces","Exercicio 1");

    Console.WriteLine(subSubPasta1.ImprimeCaminho());
  }
}