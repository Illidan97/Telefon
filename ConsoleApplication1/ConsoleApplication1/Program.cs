using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char koniec = 'q';
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(DateTime.Now);
                System.Threading.Thread.Sleep(1000);
            } while (koniec == 'q');
            //program należy dokończyć
        }
    }
}