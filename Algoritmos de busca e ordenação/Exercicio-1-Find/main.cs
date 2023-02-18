using System;

class Program
{
    public static void Main(string[] args)
    {
        //instanciar vetor
        int[] vetor = new int[5];

        int busca;

        //preencher vetor
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite um numero:");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        //ler chave
        Console.Write("Digite elemento a buscar:");
        busca = int.Parse(Console.ReadLine());

        //buscar elemento
        int numero = Array.Find(vetor, x => x == busca);
        if (numero == busca)
        {
            Console.Write("Elemento encontrado!");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado!");
        }
    }
}