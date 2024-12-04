using System;

namespace ProgramaPrincipal
{

    class Program
    {
        static void Main(string[] args)
        {
            ExibirMenu();

            }
            
        

        static void ExibirMenu() {

            Console.Clear();

            while (true) {

            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("0. Sair");   

            Console.WriteLine("");
                
                Console.WriteLine("DIgite a operação que deseja realizar:");

                int operacao = int.Parse(Console.ReadLine());

                switch (operacao) {

                    case 1:
                    Somar();
                    break;

                    case 2:
                    Subtracao();
                    break;

                    case 3:
                    Divisao();
                    break;

                    case 4: 
                    Multiplicacao();
                    break;

                    case 0:
                    System.Environment.Exit(0);
                    break;

                    default: 
                    return;
                                      

            }

        }

    }

        static void Somar() {


            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------");

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O valor total dessa soma é {valor1 + valor2}");

            Console.WriteLine("");

        }

        static void Subtracao() {


            Console.Clear();

            Console.WriteLine("Digite o valor a ser subtraído: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"A subtração entre esses dois valores é {valor1 - valor2}");

            Console.WriteLine("");

        }

        static void Divisao() {

            Console.Clear();

            Console.WriteLine("Digite o numerador: ");
            float numerador = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");

            Console.WriteLine("Digite o denominador: ");
            float denominador = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado dessa divisão é {numerador / denominador}");

            Console.WriteLine("");
            
        }

        static void Multiplicacao() {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor a multiplicar: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");

            Console.WriteLine("DIgite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"A multiplicação entre esse dois valores é {valor1 * valor2}");

            Console.WriteLine("");

        }


    }

}


