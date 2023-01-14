using System;

public class Escola{
  private string nomeEscola, endereco;
  public static  int instancias = 0;

  //construtores
  public Escola (){
    this.nomeEscola = "";
    this.endereco = "";
    Escola.instancias++;
  }

  public Escola(string nome, string endereco){
    this.nomeEscola =  nome;
    this.endereco = endereco;
    Escola.instancias++;
  }

  //destrutores
  ~Escola(){
    Escola.instancias--;
  }

  //Propriedades
  public string Nome{
    get => this.nomeEscola;
    set{
      if (value.Length>=4)
        nomeEscola = value;
    }
  }
  public string Endereco{
    get => this.endereco;
    set{
      if (value.Length>=4)
        endereco = value;
    }
  }
  
}//fim Escola

public class Aluno:Escola{
  private string nome;
  private double nota;
  public static int contador = 0;

  //construtores
  public Aluno(){
    this.nome = "";
    this.nota = 0;
    Aluno.contador++;
  }
  public Aluno(string escola,string local,string nome, double nota):base(escola,local){
    this.nome = nome;
    this.nota = nota;
    Aluno.contador++;
  }

//destrutor
   ~Aluno(){
    Aluno.contador--;
  }

  //método 
  public override string ToString(){
    return nome+" da escola "+base.Nome+" local: "+base.Endereco+" obteve a nota "+nota;
  }
  
}



class Program {
  public static void Main (string[] args) {
    //instanciar  vetor alunos
    Aluno [] alunos = new Aluno[5];
    string nome;
    double nota;

    //preencher vetor
    for (int i = 0;i<5;i++){
      Console.WriteLine("Nome do ALuno: ");
      nome = Console.ReadLine();
      Console.WriteLine("Nota do ALuno: ");
      nota = Double.Parse(Console.ReadLine());
      alunos[i] = new Aluno("Promove","Bom Despacho,MG",nome,nota);
    }

    //após preencher
    Console.WriteLine("instancias antes do destrutor: "+Aluno.contador);


    //executar destrutor
    for (int i = 0;i < 5;i++){
      alunos[i] = null;
       System.GC.Collect();
    }
   
    Console.WriteLine("instancias: "+Aluno.contador);
  }
}