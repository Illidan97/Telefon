using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal abstract class IPhone : Mobile
    {
        public void TouchID()
        {
            Console.WriteLine("ID potwierdzone telefon zostanie odblokowany");
        }

        public void WyslijSMS()
        {
            Console.WriteLine("SMS został wysłany z IPhone");
        }
    }
}