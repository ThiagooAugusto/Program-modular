using System;
using System.Collections;

public class Utente{
  //atributos de instante
  private string nome;
  private int anoNascimento;

  //construtores
  public Utente(){
    this.nome = "";
    this.anoNascimento = 0;
  }
  public Utente(string nome, int ano){
    this.nome = nome;
    this.anoNascimento = ano;
  }

  //acessor
  public string GetNome{
    get{
      return this.nome;
    }
  }

  //metodo p calcular idade
  public int CalculaIdade(){
    return DateTime.Now.Year - this.anoNascimento;
  }
}

class ListaObjetos {
  public static void Main (string[] args) {
    string nome;
    int ano;
    ArrayList listaClientes = new ArrayList();

    
    for(int i = 0; i < 5; i++){
      Console.Write("Digite o nome do cliente:");
      nome = Console.ReadLine();
      Console.Write("Digite o ano de nascimento do cliente:");
      ano = int.Parse(Console.ReadLine());
      listaClientes.Add(new Utente(nome,ano));
    }

    //imprimir lista
    Console.WriteLine("----Lista de clientes----");
    foreach(Utente u in listaClientes){
      Console.WriteLine("Nome: {0} - Idade:{1}", u.GetNome, u.CalculaIdade());
    }
    Console.Write("O spa possui {0} clientes",listaClientes.Count);
  }
}