using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5]; 
            int Min = A[0]; int Max = A[0];

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Введите элемент массива:", i);
                A[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            for (int i = 1; i < 5; i++) {
                if (A[i] < Min ) {
                    Min = A[i];
                }
            }

            for (int i = 1; i < 5; i++) { 
                if ( A[i] > Max ) {  
                    Max = A[i];       
                }
            }

            Console.WriteLine("Минимальный элемент = " + Min);
            Console.WriteLine("Максимальный элемент = " + Max);
            Console.ReadKey();
        }
    }
}
