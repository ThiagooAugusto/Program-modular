using System;

public class Pessoa{
  //atributos
  private string nome;
  private string telefone;

  //construtores
  public Pessoa(){
    this.nome = "";
    this.telefone = "";
  }
  public Pessoa(string nome, string telefone){
    this.nome = nome;
    this.telefone = telefone;
  }

  //acessadores
  public string Nome{
    get{
    return this.nome;
    }
  }
  public string Telefone{
    get{
    return this.telefone;
    }
  }
}

public class Colega:Pessoa{
  private string localTrabalho;
  private string cargo;

  //construtor
  public Colega(string nome,string telefone,string local,string profissao ):base(nome,telefone){
    this.localTrabalho = local;
    this.cargo = profissao;
  }

  //acessores
  public string LocalTrabalho{
     get{
    return this.localTrabalho;
    }
  }
  public string getCargo(){
    return cargo;
  }
}

public class Amigo:Pessoa{
  private string local;
  private string anoConhecimento;

  //construtor
  public Amigo(string nome, string telefone,string onde,string quando):base(nome,telefone){
    this.anoConhecimento = quando;
    this.local = onde;
  }

  //acessores
  public string Local{
     get{
    return this.local;
    }
  }
  public string AnoConhecimento{
     get{
    return this.anoConhecimento;
    }
  }
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}