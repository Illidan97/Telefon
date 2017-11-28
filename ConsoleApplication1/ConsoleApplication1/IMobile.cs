using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal interface IMobile
    {
        string KartaSim();

        int PamiecWewnetrzna();

        void WyslijSMS();

        void ZrobZdjecie();
    }
}