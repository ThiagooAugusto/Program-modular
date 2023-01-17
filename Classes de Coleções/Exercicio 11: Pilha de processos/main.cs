using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        //instanciar pilha
        Stack codigos = new Stack();

        //chamar metodos
        ColocaNaPilha(codigos);
        ImprimeOrdem(codigos);
    }
    //metodos
    public static void ColocaNaPilha(Stack pilha)
    {
        string codigo;

        Console.Write("Digite o codigo do processo ou 0 para sair: ");
        codigo = Console.ReadLine();

        //preencher pilha
        while (codigo != "0")
        {
            pilha.Push(codigo);
            Console.Write("Digite o codigo do processo ou 0 para sair: ");
            codigo = Console.ReadLine();
        }
    }

    public static void ImprimeOrdem(Stack pilha)
    {
        Console.WriteLine("\n ordem de resoluçao:");

        while(pilha.Count > 0){
          Console.WriteLine(pilha.Peek());
          pilha.Pop();
        }
      
    }
}