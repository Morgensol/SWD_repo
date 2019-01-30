using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motorbike;

namespace Vechicle.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            GasEngine MyGasEngine = new GasEngine(50);
            MotorBike MyBike= new MotorBike(MyGasEngine);
            DieselEngine MyDieselEngine = new DieselEngine(100);
            MotorBike MyNewBike = new MotorBike(MyGasEngine);
        }
    }
}
