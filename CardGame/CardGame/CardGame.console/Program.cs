using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc1 = new BlueCard(8);
            Console.WriteLine(rc1.calculateValue());
        }
    }
}
