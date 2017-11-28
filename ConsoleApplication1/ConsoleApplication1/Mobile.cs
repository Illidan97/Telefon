using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal abstract class Mobile : IMobile
    {
        private string kartaSim;
        private string numerIMEI;
        private int pamiecWewnetrzna;
        private string procesor;

        public string KartaSim
        {
            get { return kartaSim; }
            set { kartaSim = value; }
        }

        public int PamiecWewnetrzna
        {
            get { return pamiecWewnetrzna; }
        }

        public string Procesor
        {
            get { return procesor; }
        }

        public void OdbierzPolaczenie()
        {
            Console.WriteLine("Połączenie przychodzące, odbierz");
        }

        public void PobierzNumerIMEI()
        {
            Console.WriteLine("Numer IMEI został pobrany");
        }

        public void WykonajPolaczenie()
        {
            Console.WriteLine("Połączenie zostanie wykonane");
        }

        public void WyslijSMS()
        {
            Console.WriteLine("SMS został wysłany");
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Zdjęcie zostało zrobione i zapisane");
        }

        string IMobile.KartaSim()
        {
            throw new NotImplementedException();
        }

        int IMobile.PamiecWewnetrzna()
        {
            throw new NotImplementedException();
        }
    }
}