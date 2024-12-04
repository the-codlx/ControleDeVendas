using System;
using System.Diagnostics.Contracts;

namespace EditorHtml {

    public static class Menu {


        public static void Show() {

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();

            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);

        }

        public static void DrawScreen() {

            Lines();

            for(int lines = 0; lines <= 10; lines++) {

                Console.Write("|");
                for(int i = 0; i <= 30; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");

            }

            Lines();

        }

        public static void Lines() {

            Console.Write("*");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("*");
            Console.Write("\n");

        }

        public static void WriteOptions() {
            
            Console.SetCursorPosition(11, 1);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(8, 2);
            Console.WriteLine("=================");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Opções:");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo: ");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Opção:");

            Console.SetCursorPosition(10, 10);

        }

        public static void HandleMenuOption(short option) {

            switch(option) {

                case 1: Editor.Show(); break;
                
                case 2: Console.WriteLine("View"); break;

                case 0: {
                    
                    Console.Clear();
                    Environment.Exit(0); 
                    break;
                
                    }

                default: Show(); break;

                }

    }

}

}