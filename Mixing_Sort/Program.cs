using System;

namespace Mixing_Sort
{
    class Program
    {

        // Сортировка перемешивания


        /*при прохождении части массива, происходит проверка, были ли перестановки. 
         * Если их не было, значит, эта часть массива уже упорядочена и она исключается из дальнейшей обработки.
         * Кроме того, при прохождении массива от начала к концу, минимальные элементы перемещаются в самое начало,
         * а максимальный элемент сдвигается к концу массива.*/
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void CocktailSort(int[] inArray)
        {
            int left = 0,
                 right = inArray.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (inArray[i] > inArray[i + 1])
                        Swap(inArray, i, i + 1);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (inArray[i - 1] > inArray[i])
                        Swap(inArray, i - 1, i);
                }
                left++;
            }
            for (int a = 0; a < inArray.Length; a++)
            {
                Console.Write(inArray[a] + " ");
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

            Console.Write("\n ");
            CocktailSort(arr);
        }
    }
}
