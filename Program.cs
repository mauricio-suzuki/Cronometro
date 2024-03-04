using System.Threading;
using System;

class Program
{
    static void Main(string[] args)
    {

        Menu();
    }

    static void Menu()
    {

        Console.WriteLine("M -> Tempo em minutos, EX: 10M");
        Console.WriteLine("S -> Tempo em segundos, EX: 10S");
        Console.WriteLine("0 - Sair");
        string opcao = Console.ReadLine().ToLower();
        char type = char.Parse(opcao.Substring(opcao.Length - 1, 1));
        int time = int.Parse(opcao.Substring(0, opcao.Length - 1));

        int multiplicador = 1;

        if (type == 'm')
        {
            multiplicador = 60;
        }

        Start(time * multiplicador);


    }

    static void Start(int tempo)
    {
        int tempoAtual = 0;

        while (tempoAtual != tempo)
        {
            Console.Clear();
            tempoAtual++;
            Console.WriteLine(tempoAtual);

            Thread.Sleep(1000);

        }
    }
}