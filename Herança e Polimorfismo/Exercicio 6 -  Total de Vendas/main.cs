using System;

public class Vendas{
  //atributos
  public static double vendaTotal = 0;

  //métodos
  public static void AtualizaSoma(double x){
    vendaTotal = vendaTotal + x;
  }

  public static double RetornaSoma(){
    return vendaTotal;
  }
}

public class VendasProdA:Vendas{
  //atributos
  private int quantidade;
  private double precoUnitario;

  //construtor para atualizar o valor total das vendas
  public VendasProdA(int quant, double preco){
    this.quantidade = quant;
    this.precoUnitario = preco;
    Vendas.AtualizaSoma(this.quantidade * this.precoUnitario);
  }
}

public class VendasProdB:Vendas{
  //atributos
  private double valorTransacao;

//construtor
  public VendasProdB(double trans){
    this.valorTransacao = trans;
    Vendas.AtualizaSoma(this.valorTransacao);
  }
}



class Program {
  public static void Main (string[] args) {
    int quantidade;
    double valor;
    string continuar = "S";

    while (continuar == "S"){
      Console.WriteLine("Produto A ");
      Console.Write("valor: ");
      valor = double.Parse(Console.ReadLine());
      Console.Write("quantidade: ");
      quantidade = int.Parse(Console.ReadLine());
      VendasProdA produtoA = new VendasProdA(quantidade,valor);
      
      Console.WriteLine("Produto B ");
      Console.Write("valor: ");
      valor = double.Parse(Console.ReadLine());
      VendasProdB produtB = new VendasProdB(valor);
      Console.WriteLine("Deseja continuar: S ou N?: ");
      continuar = Console.ReadLine();
    }
    Console.Write("A venda total dos produtos é "+Vendas.vendaTotal);
    
  }
}