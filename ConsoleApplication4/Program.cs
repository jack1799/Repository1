using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 5, 4, 3, 2, 1 };
            Console.WriteLine("Был массив");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            QuickSort(a, 0, a.Length - 1);
            Console.WriteLine("Получили массив");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void QuickSort(double[] array, int FirstArrayIndex, int SecondArrayIndex)
        {
            int FirstChangingIndex = FirstArrayIndex;
            int SecondChangingIndex = SecondArrayIndex;
            double ReferenceElement;
            if (SecondArrayIndex > FirstArrayIndex)
            {
                ReferenceElement = array[(FirstArrayIndex + SecondArrayIndex) / 2];
                while (FirstChangingIndex <= SecondChangingIndex)
                {
                    while ((FirstChangingIndex < SecondArrayIndex) && (array[FirstChangingIndex] < ReferenceElement)) ++FirstChangingIndex;             
                    while ((SecondChangingIndex > FirstArrayIndex) && (array[SecondChangingIndex] > ReferenceElement)) --SecondChangingIndex;
                   if (FirstChangingIndex <= SecondChangingIndex)
                    {
                        double T;
                        T = array[FirstChangingIndex];
                        array[FirstChangingIndex] = array[SecondChangingIndex];
                        array[SecondChangingIndex] = T;
                        ++FirstChangingIndex;
                        --SecondChangingIndex;
                    }
                } 
                if (FirstArrayIndex < SecondChangingIndex) QuickSort(array, FirstArrayIndex, SecondChangingIndex);               
                if (FirstChangingIndex < SecondArrayIndex) QuickSort(array, FirstChangingIndex, SecondArrayIndex);
            }
        }
    }
}
