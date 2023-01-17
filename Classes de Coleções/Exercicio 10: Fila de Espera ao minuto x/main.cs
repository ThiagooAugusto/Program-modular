using System;
using System.Collections;

public class RegistroFila
{
    private string nome;
    private int inicio;

    //construtor
    public RegistroFila(string nome, int minuto)
    {
        this.nome = nome;
        this.inicio = minuto;
    }

    //acessores
    public string Nome
    {
        get
        {
            return this.nome;
        }
    }

    public int Inicio
    {
        get
        {
            return this.inicio;
        }
    }
}





public class Program
{
    public static void Main(string[] args)
    {

        //instanciar
        Queue fila = new Queue();
        string[] nomes = { "joao", "maria", "jose", "pedro", "eduardo" };
        int[] duracao = { 10, 8, 4, 12, 15 };

        //chamar metodos
        ColocarNaFila(fila, nomes, duracao);

        foreach (RegistroFila r in fila)
        {
            Console.WriteLine(r.Nome);
        }



    }
    public static void ColocarNaFila(Queue q, string[] nomes, int[] duracao)
    {
        int inicio = 0;
        //preencher fila
        for (int i = 0; i < nomes.Length; i++)
        {
            RegistroFila registroFila = new RegistroFila(nomes[i], inicio);
            inicio += duracao[i];
            q.Enqueue(registroFila);
        }

    }


}