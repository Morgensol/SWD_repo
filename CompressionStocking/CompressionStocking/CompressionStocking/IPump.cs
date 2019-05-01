using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionStocking
{
    interface IPump
    {
        void runForwards(int seconds);
        void runBackwards(int seconds);
        void stop();
    }
}
