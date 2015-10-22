using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class Program
    {
        public static void QuickSort(double[] arr, int first, int last)
        {
            double p = arr[(last - first) / 2 + first];
            double temp;
            int firstEl = first, lastEl = last;
            while (firstEl <= lastEl)
            {
                while (arr[firstEl] < p && firstEl <= last)
                {
                    firstEl++;
                }
                while (arr[lastEl] > p && lastEl >= first)
                {
                    lastEl--;
                }
                if (firstEl <= lastEl)
                {
                    temp = arr[firstEl];
                    arr[firstEl] = arr[lastEl];
                    arr[lastEl] = temp;
                    firstEl++;
                    lastEl--;
                }
            }
            if (lastEl > first)
            {
                QuickSort(arr, first, lastEl);
            }
            if (firstEl < last)
            {
                QuickSort(arr, firstEl, last);
            }
        }
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            //заполняем массив случайными числами
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(0, 10);
            }
            Console.WriteLine("Неотсортированный массив: ");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }

            QuickSort (arr, 0, arr.Length - 1);
            System.Console.WriteLine("\n\n Первый отсортированный элемент массива :");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
                
            }

            System.Console.WriteLine("\n\n Нажмите пожалуйста ENTER");
            System.Console.ReadLine();

            
        }
    }
}
