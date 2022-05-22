using System;

namespace Insertion_Sort
{
    class Program
    {
        //Сортировка вставками
        /*Суть его заключается в том что, на каждом шаге алгоритма мы берем один из элементов массива, 
         находим позицию для вставки и вставляем. Стоит отметить что массив из 1-го элемента считается отсортированным.*/

        static void insertionSort(int[] arr, int length)
        {
            // i текущий элемент массива, j - индекс отсортированной части,
            //tmp - буфер для перестановки элементов массива
            int i, j, tmp;
            for (i = 1; i < length; i++)// проход по массиву
            {
                j = i;
                // проход по отсортированной части массива для вставки текущего элемента
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    //перестановка
                    tmp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;

                    j--;
                }
            }
            for (int a = 0; a < arr.Length; a++)
            {
                Console.Write(arr[a] + " ");
            }
            
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(0, 100);
            }
            
            foreach (double x in arr)
            {
                Console.Write(x + " ");
            }

            Console.Write( "\n ");
            insertionSort(arr, 10);
        }
    }
}
