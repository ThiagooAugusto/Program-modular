using System;
using System.Collections.Generic;

/*
 * Definicao da Classe Aluno com os 
 * atributos públicos e acessivéis 
 */
public class Aluno{    
    public string Nome { get; set; }    
    public int Matricula { get; set; }

    // @return - atributos concatenados como string
    public override String ToString(){
        return Nome + " - " + Matricula;
    }    
}   

/*
 * Exemplo de Pesquisa para um vetor com Alunos
 */
class MainClass {

    /*
     * Menu para exibição das opções
     */
    public static void Menu(){
        Console.WriteLine("1 - Para cadastrar aluno");
        Console.WriteLine("2 - Para pesquisar aluno por matricula");
        Console.WriteLine("3 - Para mostrar todos alunos");
        Console.WriteLine("4 - Para sair..");
    }

    /*
     * Pesquisa Sequencial
     * Busca alunos pelo campo chave matricula
     * @return true/false como resposta da pesquisa
     */
    public static bool PesquisaAlunos(Aluno [] vetor, int limite, int chave){
        bool resp = false;
        for(int i=0; i<limite; i++){
            if(vetor[i].Matricula == chave){
                resp = true;
                i = limite;
            }
        }
        return resp;
    }

    public static void Main (string[] args) {
        // Declara e inicializa uma vetor para alunos
        Aluno []alunos = new Aluno[20];
        int count = 0; // Contador para alunos
        // Variavel para opcao escolhida
        int opcao;
        Menu();
        opcao = Int32.Parse(Console.ReadLine());

        while(opcao != 4){
            switch(opcao){
                case 1: // Leitura de dados do aluno e adiciona no Vetor de Alunos
                    Aluno temp = new Aluno();
                    Console.WriteLine("Informe o nome do aluno");
                    temp.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o número de matricula");
                    temp.Matricula = Int32.Parse(Console.ReadLine());
                    alunos[count] = temp;
                    count++;
                    break;

                case 2: // Pesquisa aluno pela matricula
                    Console.WriteLine("Informe o numero de matricula: ");
                    int matricula = Int32.Parse(Console.ReadLine());
                    // Usando Pesquisa Sequencial para encontrar o Aluno pela matricula
                    if(PesquisaAlunos(alunos, count, matricula)){
                        Console.WriteLine("Aluno cadastrado!!!");
                    } else {
                        Console.WriteLine("Aluno não cadastrado!!!");
                    }
                    break;

                case 3: // Imprime na tela todos os alunos cadastrados
                    for(int i=0; i<count; i++)
                        Console.WriteLine(alunos[i].ToString());
                    break;
            }
            Console.ReadKey(); // para pausa
            Console.Clear(); // clear a tela
            Menu(); //exibe menu de opçoes
            opcao = Int32.Parse(Console.ReadLine());
        }

    }    

}