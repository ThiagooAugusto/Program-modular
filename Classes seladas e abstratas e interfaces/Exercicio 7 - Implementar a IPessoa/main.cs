using System;

public interface IPessoa{
  public string NomeCompleto{
    get;
  }
  public int Idade();
}

public class Utente:IPessoa{
  private string nome;
  private DateOnly dataNascimento;

  //construtor
  public Utente(string n, DateOnly data){
    this.nome = n;
    this.dataNascimento = data;
  }

  //metodos
  public string NomeCompleto{
    get{
      return this.nome;
    }
  }

  public int Idade(){
    return  DateTime.Now.Year - dataNascimento.Year;
  }
  
}//fim Utente

class Program {
  public static void Main (string[] args) {
    //criar instancias
    Utente pessoa1 = new Utente("Teresa,Paiva",new DateOnly(1970,4,10));
    Utente pessoa2 = new Utente("Joaquim,Aires",new DateOnly(1980,12,8));
    Utente pessoa3 = new Utente("Rui,Taveira",new DateOnly(1995,3,16));

    Console.WriteLine($"Pessoa 1 - Nome: {pessoa1.NomeCompleto} Idade: {pessoa1.Idade()}");
      Console.WriteLine($"Pessoa 2 - Nome: {pessoa2.NomeCompleto} Idade: {pessoa2.Idade()}");
      Console.WriteLine($"Pessoa 3 - Nome: {pessoa1.NomeCompleto} Idade: {pessoa3.Idade()}");
  }
}