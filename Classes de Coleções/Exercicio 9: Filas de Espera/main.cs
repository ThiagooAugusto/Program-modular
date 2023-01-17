using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        //instanciar fila
        Queue filaEspera = new Queue();

        //executar metodos
        ColocarNaFila(filaEspera);
        ImprimirFila(filaEspera);
    }

    public static void ColocarNaFila(Queue fila)
    {
        string nome;

        Console.WriteLine("Digite o nome ou 0 para sair:");
        nome = Console.ReadLine();

        while (nome != "0")
        {
            fila.Enqueue(nome);
            Console.Write("Digite o nome ou 0 para sair:");
            nome = Console.ReadLine();
        }

    }
    public static void ImprimirFila(Queue fila)
    {
        IEnumerator iterador = fila.GetEnumerator();
        iterador.MoveNext();

        Console.WriteLine("----Lista de Espera----");
        for (int i = 0; i < fila.Count; i++)
        {
            Console.WriteLine(iterador.Current);
            iterador.MoveNext();
        }
        Console.WriteLine($"Estão na fila {fila.Count} pessoas");
    }

}