using System;

public interface IEmpregado{
  //métodos
  public double CalculaSalario();
  public int TempoTrabalhado(int anoAtual);
}//fim interface

public abstract class Pessoa{
  protected string nome;

  //construtor
  public Pessoa(string n){
    this.nome = n;
  }

  //acessor
  public abstract string LerNome();
  
}//fim Pessoa

public class Empregado:Pessoa,IEmpregado{
  private int anoEntrada;
  private double salarioHora;
  private int horasTrabalhadas;

  //construtor
  public Empregado(string nome,int ano,double sHora, int horas):base(nome){
    this.anoEntrada = ano;
    this.salarioHora = sHora;
    this.horasTrabalhadas  = horas;
  }

  //acessor
  public int AnoAdmissao(){
    return this.anoEntrada;
  }

    //metodos
    public override string LerNome()
    {
        return this.nome;
    }

  //implementar metodos da interface
  public double CalculaSalario(){
    return salarioHora*horasTrabalhadas;
  }
  public int TempoTrabalhado(int anoAtual){
    return anoAtual - anoEntrada;
  }
}

//metodos


class Program {
  public static void Main (string[] args) {
    Empregado empregado1 = new Empregado("Joao",2008,30,240);
    Console.WriteLine($"Empregado {empregado1.LerNome()} - Ano de admissao: {empregado1.AnoAdmissao()} - Salário: {empregado1.CalculaSalario()} Tempo de Empresa: {empregado1.TempoTrabalhado(2022)}");
  }
}