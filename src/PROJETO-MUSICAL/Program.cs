﻿using System;

namespace PROJETO_MUSICAL
{
    public class Program
    {
        // Screen Sound
        const string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

        public static void Main(string[] args)
        {
            ExibirOpcoesDoMenu();
        }

        static void ExibirLogo()
        {
            Console.WriteLine(@"
            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
            ");

            Console.WriteLine(mensagemDeBoasVindas);
        }

        static void ExibirOpcoesDoMenu()
        {
            ExibirLogo();

            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 0:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente uma das opções acima");
                    break;
            }
        }
    }
}








