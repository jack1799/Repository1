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
            QuickSort(a, 0, a.Length - 1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void QuickSort(double[] array, int FirstArrayIndex, int SecondArrayIndex)
        {
            int A = FirstArrayIndex;
            int B = SecondArrayIndex;
            double ReferenceElement;
            if (SecondArrayIndex > FirstArrayIndex)
            {
                ReferenceElement = array[(FirstArrayIndex + SecondArrayIndex) / 2];
                while (A <= B)
                {
                    while ((A < SecondArrayIndex) && (array[A] < ReferenceElement)) ++A;             
                    while ((B > FirstArrayIndex) && (array[B] > ReferenceElement)) --B;
                   if (A <= B)
                    {
                        double T;
                        T = array[A];
                        array[A] = array[B];
                        array[B] = T;
                        ++A;
                        --B;
                    }
                } 
                if (FirstArrayIndex < B) QuickSort(array, FirstArrayIndex, B);               
                if (A < SecondArrayIndex) QuickSort(array, A, SecondArrayIndex);
            }
        }
    }
}
