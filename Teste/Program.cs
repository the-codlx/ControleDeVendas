using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace Testando
{

    public static class Teste
    {

        public static void Main(String[] args)
        {

            Console.Clear();

            /*var date = DateTime.Now;

            var formatada = String.Format("{0:y--M--ddd }", date);
            
            Console.WriteLine(formatada); */

            var pt = new CultureInfo("pt-BR");

            Console.WriteLine(pt);

        }


    }
}