﻿using System;
using System.Collections.Generic;

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
    
                
                

                    

                    
                        
                        
                    
                





        



