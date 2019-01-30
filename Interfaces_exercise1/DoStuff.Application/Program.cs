using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoThings myStuff;
            Console.WriteLine("To do Dickey pres D, else if you want to do Hickey press H");
            if (Console.ReadKey().Key==ConsoleKey.D)
            {
                myStuff = new DoDickey();
            }
            else
            {
                myStuff = new DoHickey();
            }
            ;
            myStuff.DoNothing();
            myStuff.DoSomething(2);
            myStuff.DoSomethingElse("HEJ");
        }
    }
}
