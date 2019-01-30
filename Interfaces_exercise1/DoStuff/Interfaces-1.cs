using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff
{
    public class DoHickey : IDoThings
    {
        public void DoNothing()
        {
            Console.WriteLine("DoHickey::DoNothing()");
        }

        public int DoSomething(int number)
        {
            Console.WriteLine("DoHickey::DoSomething(): " + number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            Console.WriteLine("DoHickey::DoSomethingElse(): " + input);
            return input;
        }
    }
    public class DoDickey : IDoThings
    {
        public void DoNothing()
        {
            Console.WriteLine("DoDickey::DoNothing()");
        }

        public int DoSomething(int number)
        {
            Console.WriteLine("DoDickey::DoSomething(): " + number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            Console.WriteLine("DoDickey::DoSomethingElse(): " + input);
            return input;
        }
    }
    public interface IDoThings
    {
        void DoNothing();
        int DoSomething(int number);
        string DoSomethingElse(string input);
    }
}
