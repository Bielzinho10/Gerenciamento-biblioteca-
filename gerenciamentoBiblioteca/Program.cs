using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Biblioteca
{
    static List<string> livrosDisponiveis = new List<string> {"Livro A", "Livro B", "Livro C"};
    
    static Dictionary<string, int> livrosEmprestados = new Dictionary<string, int>(); 

    static Dictionary<string, int> limitePorUsuario = new Dictionary<string, int>();

    const int limiteLivrosUsuario = 3;
    const int limiteLivrosAdmin = 10;

    static void Main (string[] args)
    {
        Console.WriteLine("Bem-vindo à Biblioteca!");
        Console.WriteLine("Você é um administrador ou usuário?");
        string tipoConta = Console.ReadLine().ToLower();

        bool administrador = tipoConta == "administrador";
        string nomeUsuario;

        if (administrador)
        {
            nomeUsuario = "Administrador";
            limitePorUsuario[nomeUsuario] = 0;
        }
        else
        {
            Console.WriteLine("Digite seu nome de usuario: ");
            nomeUsuario = Console.ReadLine();
            if(!limitePorUsuario.ContainsKey(nomeUsuario))
            {
                limitePorUsuario[nomeUsuario] = 0;
            }
        }

                int limiteLivros = administrador ? limiteLivrosAdmin : limiteLivrosUsuario;
                
                string opcao;
                do
                {
                    ExibirMenu();
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                        ListarLivros();
                        break;
                        case "2":
                        
                        EmprestarLivro(nomeUsuario, limiteLivros);
                            break;
                            case "3":

                            DevolverLivro(nomeUsuario);
                            break;
                            case "4":

                            VerificarLimite(nomeUsuario, limiteLivros);
                            break;
                            case "0":

                            Console.WriteLine("Saindo...");
                            break;
                            default:
                            Console.WriteLine("Opção inválida, tente novamente.");
                            break;
                    }
                } while (opcao !="0");  
    }

    static void ExibirMenu()
    {
        Console.WriteLine("\nMenu de opções: ");
        Console.WriteLine("1- Listar livros disponíveis");
        Console.WriteLine("2- Emprestar livro");
        Console.WriteLine("3- Devolver livro");
        Console.WriteLine("4- Verificar limite de empréstimos");
        Console.WriteLine("0- Sair");
        Console.WriteLine("Escolha uma opção: ");
    }
    
    static void ListarLivros()
    {
        Console.WriteLine("n\LivrosDisponiveis: ");
        foreach (var livro in livrosDisponiveis)
        {
            Console.WriteLine(livro);
        }
    }

    static void EmprestarLivro(string usuario, int limite)
    {
        Console.WriteLine($"Você atingiu o limite de {limite} livros emprestados.");
        return;
    }

    Console.WriteLine("Digite o nome do livro que deseja emprestar: ");
    string livro = Console.ReadLine();

    if (livrosDisponiveis.Contains(livro))
    {
        livrosDisponiveis.Remove(livro);
        if (!livrosEmprestados.ContainsKey(livro))
        {
            livrosEmprestados[livro] = 0;
        }
        livrosEmprestados[livro]++;
        limitePorUsuario[usuario]++;
        Console.WriteLine($"Você emprestou '{livro}'.");
    }
    else
    {
        Console.WriteLine("Livro não disponível.");
    }
}

static void DevolverLivro(string usuario)
{
    Console.WriteLine("Digite o nome do livro que deseja devolver: ");
    string livro = Console.ReadLine();


    if (livrosEmprestados.ContainsKey(livro) && livrosEmprestados[livro] > 0)
    {
        livrosEmprestados[livro]--;
        limitePorUsuario[usuario]--;
        livrosDisponiveis.Add(livro);
        Console.WriteLine($"Você devolveu '{livro}'.");
    }
    


                
                

                    

                    
                        
                        
                    
                





        



