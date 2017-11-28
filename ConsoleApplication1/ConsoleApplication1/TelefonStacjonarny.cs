using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class TelefonStacjonarny : IStacjonarny
    {
        private int numer;

        public TelefonStacjonarny(string numer)
        {
            this.numer = Convert.ToInt32(numer);
        }

        public int GetNumer()
        {
            return numer;
        }

        public void OdbierzPolaczenie()
        {
            Console.WriteLine("Połączenie przychodzące, podnieś słuchawkę");
        }

        public void SetNumer(int numer)
        {
            Console.WriteLine("Podaj numer: ");
            Console.ReadLine();
        }

        public void WykonajPolaczenie()
        {
            Console.WriteLine("Połączenie zostanie wykonane za chwilę, proszę czekać");
        }
    }
}