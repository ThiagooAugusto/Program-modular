using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Hashtable paisesECapitais = new Hashtable();

        //chamar metodos
        PreencheTabela(paisesECapitais);
        ConsultaCapital(paisesECapitais);

    }
    //metodos
    public static void PreencheTabela(Hashtable paises)
    {
        string pais;
        string capital;

        Console.Write("Digite o país ou 0 para sair: ");
        pais = Console.ReadLine();

        while (pais != "0")
        {
            Console.Write("Digite a capital do país: ");
            capital = Console.ReadLine();
            paises.Add(pais, capital);
            Console.Write("Digite o país ou 0 para sair: ");
            pais = Console.ReadLine();
        }
    }

    public static void ConsultaCapital(Hashtable paises)
    {
        string pais;
        Console.WriteLine("----Consulta de capitais----");

        Console.Write("\n Digite o país que quer consultar a capital ou 0 para sair: ");
        pais = Console.ReadLine();

        while (pais != "0")
        {
            if (paises.ContainsKey(pais))
            {
                Console.WriteLine("A capital de {0} é {1}", pais, paises[pais]);

            }
            else
            {
                Console.WriteLine("Pais não encontrado na tabela!");
            }
            Console.Write("Digite o país que quer consultar a capital ou 0 para sair: ");
            pais = Console.ReadLine();
        }
    }
}