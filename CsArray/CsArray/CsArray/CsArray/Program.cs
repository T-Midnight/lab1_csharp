using System;
using System.Collections.Generic;				
using System.Text;

namespace CsArray {
	class Program {
		static void Main(string[] args) 
        {
			int[] A = new int[5];
            int min, max;
           
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("Введите элемент массива:", i);
				A[i] = Convert.ToInt32(Console.ReadLine());	// если ввести буквы, то программа упадёт
			}

            try { int el = Int32.Parse(Console.ReadLine()); }
            catch (FormatException) { 
                Console.WriteLine("Некорректно. Повторите ввод."); 
            }

            min = A[0];
			for (int i = 1; i < 5; i++) {
				if (A[i] < min)
					min = A[i];
			}

            max = A[0];
			for (int i = 1; i < 5; i++) {
				if (A[i] > max) 
					max = A[i];
			}

			Console.WriteLine("Минимальный элемент = " + min);
			Console.WriteLine("Максимальный элемент = " + max);
			Console.ReadKey();
		}
	}
}