 using System;

public interface INome{
  public string NomeCompleto();
}

public class Professor:INome{
  private string titulo;
  private string nome;
  private string apelido;

  //construtor
  public Professor(string t,string n,string a){
    this.titulo = t;
    this.nome = n;
    this.apelido = a;
  }

  //método NomeCompleto
  public string NomeCompleto(){
    return "Professor "+titulo+" "+nome+" "+apelido;
  }
}//fim Professor

public class Aluno:INome{
  //atributos
  private string nome;
  private string apelido;

  //construtor
  public Aluno(string n,string a){
    this.nome = n;
    this.apelido = a;
  }

  //metodo NomeCompleto
  public string NomeCompleto(){
    return "Aluno "+nome+" "+apelido;
  }
}//fim Aluno

class Program {
  public static void Main (string[] args) {
    //instanciar objetos
    Professor professor1 = new Professor("Doutor","Hugo almeida","Pereira Bastos");
    Aluno aluno1 = new Aluno("Thiago Augusto","Cardoso e Silva");

    //chamar metodos
    Console.WriteLine(professor1.NomeCompleto());
    Console.WriteLine(aluno1.NomeCompleto());
    
  }
}