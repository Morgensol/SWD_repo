using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Temp_and_strat.ArrayGen
{
    public abstract class ArrayGen
    {
        public int[] GenerateArray(int size, int max, int seed)
        {
            var A = new int[size];
            FillArray(A,max,seed);
            return A;
        }

        protected abstract void FillArray(int[] array, int max, int seed);
    }

    public class RandomArrayGen:ArrayGen
    {
        protected override void FillArray(int[] array, int max, int seed)
        {
            var rndm = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rndm.Next(max);
            }
        }
    }
    public class NearlySortedArrayGen : ArrayGen
    {
        protected override void FillArray(int[] array, int max, int seed)
        {
            int temp = 0;
            var rand = new Random(seed);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i+=4)
            {
                array[i] = rand.Next(max);
            }
        }
    }
    public class UniqueValArrayGen : ArrayGen
    {
        protected override void FillArray(int[] array, int max, int seed)
        {

        }
    }
    public class ReverseOrderArrayGen : ArrayGen
    {
        protected override void FillArray(int[] array, int max, int seed)
        {

        }
    }

}
