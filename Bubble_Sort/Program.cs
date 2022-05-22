
using System;

namespace Bubble_Sort
{
    class Program
    {

        /*1. Прохождение по всему массиву;
          2. Сравнивание между собой пар соседних ячеек;
          3. Если при сравнении оказывается, что значение ячейки i больше, чем значение ячейки i + 1, то мы меняем значения этих ячеек местами;*/

        public static void Bubble_Sort(int[] anArray)
        {
            
            PrintArray(anArray);

            for (int i = 0; i < anArray.Length; i++)
            {
                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        Swap(ref anArray[j], ref anArray[j + 1]);
                    }
                }
            }
            PrintArray(anArray);
        }


        public static void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            
            int tmpParam = aFirstArg;           
            aFirstArg = aSecondArg;
            aSecondArg = tmpParam;
        }


        public static void PrintArray(int[] anArray)
        {

            for (int i = 0; i < anArray.Length; i++)
            {
                Console.Write(anArray[i] + " ");
            }

            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] someArray = new int[] { 10, 8, 4, 3, 15, 5, 7, 6, 9, 0 };


            Bubble_Sort(someArray);

            //Чтобы окно быстро не закрылось 
            Console.ReadKey();
        }
    }
}
