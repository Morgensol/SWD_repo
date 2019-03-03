using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supersorter
{
    public interface ISortingStrategy
    {
        void Sort(int[] A);
    }

    class BoubleSort: ISortingStrategy
    {
        public void Sort(int[] A)
        {
            int temp = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length-1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        temp = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
        }
    }

    class InsertionSort : ISortingStrategy
    {
        public void Sort(int[] A)
        {
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j =i+1; j >0; j--)
                {
                    if (A[j-1]>A[j])
                    {
                        int temp = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
        }
    }

}
