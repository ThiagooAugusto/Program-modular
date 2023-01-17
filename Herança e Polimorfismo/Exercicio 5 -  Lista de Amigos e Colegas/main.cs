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
  public string Cargo{
    get{
      return cargo;
    }
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
    int n;
    string nome,telefone,local,profissao,ano;

    //instanciar amigos
    Console.WriteLine("-----Lista Amigos-----");
    Console.WriteLine("Quantos amigos: ");
    n = int.Parse(Console.ReadLine());
    Amigo[] amigos = new Amigo[n];

    for (int i = 0;i < n;i++){
      Console.WriteLine($"Amigo {i+1}");
      Console.WriteLine("Digite o nome: ");
      nome = Console.ReadLine();
      Console.WriteLine("Digite o telefone: ");
      telefone = Console.ReadLine();
      Console.WriteLine("Digite o local conhecimento: ");
      local = Console.ReadLine();
      Console.WriteLine("Digite o ano: ");
      ano = Console.ReadLine();
      //instanciar objeto Amigo
      amigos[i] = new Amigo(nome,telefone,local,ano); 
    }

    //imprimir nome e locais
    for (int i = 0;i < n;i++){
      Console.WriteLine($"nome do amigo: {amigos[i].Nome} local: {amigos[i].Local} ");
    }
    Console.WriteLine();

    //instanciar colegas
    Console.WriteLine("-----Lista colegas-----");
    Console.WriteLine("Quantos colegas?: ");
    n = int.Parse(Console.ReadLine());
    //criar vetor de Colega
    Colega[] colegas = new Colega[n];

    for (int i = 0;i < n;i++){
      Console.WriteLine($"Colega {i+1}");
      Console.WriteLine("Digite o nome: ");
      nome = Console.ReadLine();
      Console.WriteLine("Digite o telefone: ");
      telefone = Console.ReadLine();
      Console.WriteLine("Digite o local trabalho: ");
      local = Console.ReadLine();
      Console.WriteLine("Digite a profissao: ");
      profissao = Console.ReadLine();
      //instanciar objeto Colega
      colegas[i] = new Colega(nome,telefone,local,profissao); 
    }

     //imprimir nome e profissao
    for (int i = 0;i < n;i++){
      Console.WriteLine($"nome do colega: {colegas[i].Nome} profissao: {colegas[i].Cargo} ");
    }
    
  }
}