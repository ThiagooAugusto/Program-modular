using System;

public class Aluno{
  private string nome;
  private string matricula;

  public Aluno(){
    this.nome = "";
    this.matricula ="";
  }
  public Aluno(string n,string mat){
    this.nome = n;
    this.matricula = mat;
  }

  public string Nome{
    get{
      return this.nome;
    }
    set{
      this.nome = value;
    }
  }

  public string Matricula{
    get{
      return this.matricula;
    }
    set{
      this.matricula = value;
    }
  }
 
}

class Program {
  public static void Main (string[] args) {
    string busca;
    Aluno resultado;
   
    //instanciar vetor
    Aluno [] alunos = new Aluno [5];

    //cadastro
    Console.WriteLine("----Lista de Alunos----");
    for(int i = 0;i < alunos.Length;i++){
      Aluno aluno = new Aluno();
      Console.Write("Digite o nome do aluno :");
      aluno.Nome = Console.ReadLine();
      Console.Write("Digite a matricula do aluno :");
      aluno.Matricula = Console.ReadLine();
      alunos[i] = aluno;
    }

    //pesquisa
    Console.WriteLine("----Pesquisa por matricula----");
    Console.Write("Digite matricula do aluno: ");
    busca = Console.ReadLine();

    if(Array.Exists(alunos,a => a.Matricula ==  busca)){
      resultado = Array.Find(alunos, a => a.Matricula == busca);
      Console.WriteLine($"Aluno {resultado.Nome} encontrado!");
    }
    else{
      Console.WriteLine("Aluno não encontrado!");
    }
  }
}