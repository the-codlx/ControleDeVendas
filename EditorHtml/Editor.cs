using System;
using System.Linq.Expressions;
using System.Text;

namespace EditorHtml
{

    public static class Editor
    {

        public static void Show()
        {

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------------");

            Start();

        }

        public static void Start()
        {

            var file = new StringBuilder();

            do
            {

                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------------");

            Console.WriteLine("  " +"Deseja salvar o arquivo?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {

                case 1: 
                    Salvar(file); 
                    Viewer.Show(file.ToString());
                    break;

                case 2: Viewer.Show(file.ToString()); break;

                default: Console.WriteLine("Caracter Inválido."); break;

            }


        }

        public static void Salvar(StringBuilder file)
        {
            string diretorio = @"C:\Users\Lucas\Documents\estudos\EditorHtml\Arquivos\";

            Console.Write(" Digite o nome do arquivo: ");
            string nomeArquivo = Console.ReadLine() + ".txt";

            diretorio += nomeArquivo;

            try {

                using (var save_file = new StreamWriter(diretorio)) 
                {

                    save_file.WriteLine(file);

                }

            }

            catch(Exception e) 
            {
                Console.WriteLine(e);
            } 

            

        }



    }
}