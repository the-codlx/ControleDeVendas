using System;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace Stopwatch {
    
    public class Program {

    public static void Main(String[] args) {

        Menu();

    }


    static void Menu() {

        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 10m = 10 minutos");
        Console.WriteLine("0 = Sair");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;


        if(type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);


        Start(time * multiplier);

    }

    static void Start(int time) {

        Console.Clear();

        int currentTime = 0;

        while (currentTime != time) {

            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Aplicação finalizada.");    
        Thread.Sleep(2500);

        Menu();

    }   

    }

}