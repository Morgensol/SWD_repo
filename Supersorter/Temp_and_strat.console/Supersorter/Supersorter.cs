using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Supersorter
{
    public class Supersorter
    {
        public ISortingStrategy Sorter { set; private get; }
        private long SortMethod(int[] A)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Sorter.Sort(A);
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

    }
}
