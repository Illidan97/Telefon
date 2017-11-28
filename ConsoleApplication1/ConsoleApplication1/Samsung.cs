using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal abstract class Samsung : Mobile
    {
        private bool czyDualSim;

        private bool CzyDualSim
        {
            get { return czyDualSim; }
            set { czyDualSim = value; }
        }

        public void WlaczWifi()
        {
            Console.WriteLine("Wi-fi zostanie włączone");
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Zdjęcie zostało zrobione i zapisane");
        }

        public void ZrobZdjecie(string trybKamery)
        {
            if (trybKamery == "Przód")
                Console.WriteLine("Zdjęcie zostało zrobione przednim aparatem");
            else
                Console.WriteLine("Zdjęcie zostało zrobione tylnym aparatem");
        }
    }
}