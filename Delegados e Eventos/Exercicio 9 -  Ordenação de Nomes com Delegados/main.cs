using System;

public class ParDeObjetos{
  public delegate int Ordenar(object a, object b);

  //atributos
  private object [] oPar = new object[2];

  //construtor
  public ParDeObjetos(object a, object b){
    oPar[0] = a;
    oPar[1] = b;
  }

  
  //métodos
  public  void Ordem(Ordenar FuncaoDel){
    object temporario = new object();
    // chamar o delegado recebido como parametro que aponta para o método de comparação OrdemNomes da classe Pessoa
    if (FuncaoDel(oPar[0],oPar[1])== 2){
      temporario = oPar[0];
      oPar[0] = oPar[1];
      oPar[1] = temporario;
    }
  }
  public override string ToString( ){
    return oPar[0].ToString() + " e " + oPar[1].ToString();
  }
}//fim ParDeObjetos


public class Pessoa{
  private string nome;

  public Pessoa(string nome){
    this.nome = nome;
  }

  //métodos
  public static int OrdemNomes(object a, object b){
    Pessoa p1 = (Pessoa)a;
    Pessoa p2 = (Pessoa)b;
    return (String.Compare(p1.nome,p2.nome) < 0 ? 1: 2);
  }
   public override string ToString( ){
    return this.nome;
  }
  
}


class Program {
  public static void Main (string[] args) {
    //instanciar pessoas
    Pessoa p1 = new Pessoa("Pedro");
    Pessoa p2 = new Pessoa("Maria");

    //instanciar par de objetos
    ParDeObjetos par = new ParDeObjetos(p1,p2);

    //instanciar delegado
    ParDeObjetos.Ordenar delegado = new ParDeObjetos.Ordenar(Pessoa.OrdemNomes);

    //invocar método para ordenar os nomes da classe ParDeObjetos, com delegado(que executa método para comparar nomes e retorna int) como parametro
    par.Ordem(delegado);

    //mostrar na tela
    Console.WriteLine(par.ToString());
    
  }
}