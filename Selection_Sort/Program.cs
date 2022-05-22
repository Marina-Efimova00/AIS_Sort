using System;

namespace Selection_Sort
{
    class Program
    {
        // Сортировка выбором

        /*1. В неотсортированном подмассиве ищется локальный максимум (минимум).
          2. Найденный максимум (минимум) меняется местами с последним (первым) элементом в подмассиве.
          3. Если в массиве остались неотсортированные подмассивы — смотри пункт 1.*/
        public static void Sort1()
        {
            int[] arr = { 55, 14, 23, 5, 6, 76, 2 };

            foreach (double x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("");
            int min = 0;
            int t = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                t = arr[i];
                arr[i] = arr[min];
                arr[min] = t;

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Sort1();
        }
    }
}
