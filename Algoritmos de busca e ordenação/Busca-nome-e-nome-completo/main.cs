using System;

public class Aluno
{
    private string nome;
    private string matricula;
   

    //construtores
    public Aluno()
    {
        this.nome = "";
        this.matricula = "";
    }
    public Aluno(string n, string mat)
    {
        this.nome = n;
        this.matricula = mat;
    }

    //acessores
    public string Nome
    {
        get
        {
            return this.nome;
        }
        set
        {
            this.nome = value;
        }
    }

    public string Matricula
    {
        get
        {
            return this.matricula;
        }
        set
        {
            this.matricula = value;
        }
    }

 

    //cadastro
    public static void Cadastro(Aluno[] alunos)
    {
        Console.WriteLine("----Lista de Alunos----");
        for (int i = 0; i < alunos.Length; i++)
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome completo do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a matricula do aluno:");
            aluno.Matricula = Console.ReadLine();
            alunos[i] = aluno;
        }
       
    }

    //pesquisa
    public static void MetodoPesquisa(Aluno[] alunos)
    {
        int opcao;
        string busca;
        Aluno resultado;

        Console.WriteLine("----Métodos de pesquisa----");
        Console.WriteLine("Digite 1 para pesquisa por matricula:");
        Console.WriteLine("Digite 2 para pesquisa por nome:");
        Console.WriteLine("Digite 3 para pesquisa por nome completo:");
        opcao = int.Parse(Console.ReadLine());
      

        switch (opcao)
        {
            case 1:
                Console.Write("Digite matricula do aluno: ");
                busca = Console.ReadLine();

                if (Array.Exists(alunos, a => a.Matricula == busca))
                {
                    resultado = Array.Find(alunos, a => a.Matricula == busca);
                    Console.WriteLine($"Aluno {resultado.Nome} encontrado!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!");
                }
                break;

            case 2:
                Console.Write("Digite nome do aluno: ");
                busca = Console.ReadLine();

                if (Array.Exists(alunos, a => a.Nome.Substring(0,busca.Length) == busca) )
                {
   
                    Console.WriteLine($"Aluno {busca} encontrado!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!");
                }
                break;
            case 3:
                Console.Write("Digite nome do aluno: ");
                busca = Console.ReadLine();

                if (Array.Exists(alunos, a => a.Nome == busca))
                {
                    resultado = Array.Find(alunos, a => a.Nome.Contains(busca));
                    Console.WriteLine($"Aluno {resultado.Nome} encontrado!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!");
                }
                break;
        }

    }
}

class Program
{
    public static void Main(string[] args)
    {
        //instanciar vetor
        Aluno[] alunos = new Aluno[5];

        //chamar metodos
        Aluno.Cadastro(alunos);
        Aluno.MetodoPesquisa(alunos);
    }
}