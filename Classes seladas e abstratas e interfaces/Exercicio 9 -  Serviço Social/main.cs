using System;
public interface IPessoa{
  public string NomeCompleto{
    get;
  }
  public int Idade();
}//fim Ipessoa

public class ServicoSocial{
  protected string localizacao;

  public ServicoSocial(string local){
    this.localizacao = local;
  }

  public string Localizacao{
    get{
      return this.localizacao;
    }   
  }
}//fim ServicoSocial

public class Utente: ServicoSocial,IPessoa{
  private string nomeProprio;
  private string apelido;
  private int anoNasc;

  public Utente(string local,string np,string ap, int ano):base(local){
    this.nomeProprio = np;
    this.apelido = ap;
    this.anoNasc = ano;
  }

  public string NomeCompleto{
    get{
       return nomeProprio+" "+apelido;
    } 
  }
  public int Idade(){
    return DateTime.Now.Year - anoNasc;
  }
}//fim Utente

class Program {
  public static void Main (string[] args) {
    Utente [] U = new Utente[4];
    U[0] = new Utente("bh","Teresa","Paiva",1970);
     U[1] = new Utente("bom Despacho","José","Silva",1980);
     U[2] = new Utente("SP","Pedro","Moreira",1965);
     U[3] = new Utente("RJ","José","Aloísio",2000);

    foreach(var u in U){
      Console.WriteLine(u.Localizacao+" - "+u.NomeCompleto + " tem "+u.Idade()+" anos");
    }
  }
}