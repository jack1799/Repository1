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
         static void QuickSort(double[] array, int firstArrayIndex, int secondArrayIndex)
         { 
             int firstChangingIndex = firstArrayIndex; 
             int secondChangingIndex = secondArrayIndex; 
             double referenceElement; 
             if (secondArrayIndex > firstArrayIndex) 
             { 
                 referenceElement = array[(firstArrayIndex + secondArrayIndex) / 2]; 
                 while (firstChangingIndex <= secondChangingIndex) 
                 {
                    while ((firstChangingIndex < secondArrayIndex) && (array[firstChangingIndex] < referenceElement))
                    {
                        ++firstChangingIndex;
                    }
                    while ((secondChangingIndex > firstArrayIndex) && (array[secondChangingIndex] > referenceElement))
                    {
                        --secondChangingIndex;
                    }
                    if (firstChangingIndex <= secondChangingIndex) 
                     { 
                         double t; 
                         t = array[firstChangingIndex]; 
                         array[firstChangingIndex] = array[secondChangingIndex]; 
                         array[secondChangingIndex] = t; 
                         ++firstChangingIndex; 
                         --secondChangingIndex; 
                     } 
                 }
                if (firstArrayIndex < secondChangingIndex)
                {
                    QuickSort(array, firstArrayIndex, secondChangingIndex);
                }
                if (firstChangingIndex < secondArrayIndex)
                {
                    QuickSort(array, firstChangingIndex, secondArrayIndex);
                }
              } 
         } 
     } 
 } 
