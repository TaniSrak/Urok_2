using System;
//зубчатые массивы, строки и тд

namespace Urok_2
{
    internal class Program
    {
        //Enum
        enum En { el1, el2 };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //массивы одномерные и многомерные
            int[,] arr = new int[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };
            Console.WriteLine(arr[0, 0]);

            //зубчатый тип массивов
            int[][] arr2 = new int[3][]; //массив с массивами, размер не указываем
            arr2[0] = new int[] { 1, 2 };

            //foreach
            int[] ss = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in ss)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            //task1 создать массив
            /* int[] arr3 = new int[] { 1, 23, 2, 3, 13, 33, 32, 22, 45, 43, 44, 3456345, 23423, 4523, 123 };
             int even = 0;
             int odd = 0;
             int unique = 0;

             foreach (int item in arr3)
             {
                 if (item % 2 == 0)
                 {
                     even++;
                 }
                 else
                 {
                     odd++;
                 }
                 for (int i = 0; i < arr3.Length; i++)
                 {
                     bool isUnique = true;
                     for (int j = i; j < arr3.Length; j++)
                     {
                         if (i != j && arr3[i] == arr3[j])
                         {
                             isUnique = false;
                             break;
                         }
                     }
                     if (isUnique)
                     {
                         unique++;
                     }
                 }
             }
            */

            //Task2
            /*int[] arr4 = new int[] { 1, 23, 2, 3, 13, 33, 32, 22, 45, 43, 44, 3456345, 23423, 4523, 123 };
            int unique1 = 0;
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            foreach (int item in arr4)
            {
                if (item < a)
                {
                    unique1++;
                    Console.WriteLine(item);
                }

            }
            */

            //Task3
            /*int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            foreach (var item in array)
            {
                if(item < num)
                {
                    count++;
                }
            }
            */

            //Task4
            /*int[,] matrix = { { 2, 1 }, { 4, 3 }, { 1, 2 } };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int min = matrix[0, 0], max = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i,j];
                    }
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            */

            //String
            string str = "dadanene";
            char[] a = str.ToCharArray();

            //Task1 посчитать количество слов в строке
            /*string str2 = Console.ReadLine();
            string[] words = str2.Split(" ");

            Console.WriteLine(words.Length);
            */

            //Task2
            /*
            string str3 = Console.ReadLine();
            string[] words2 = str3.Split(" ");

            foreach (var word in words2)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWords = new string(charArray);
                Console.Write(reversedWords + " ");
            }*/

            //Форматирование строк.

            //1. Интерполяция строк
            int num = 10;
            string str4 = $"цена: {num}";
            //2.Метод  String.Format
            string str5 = String.Format("skfbaaaaaa {0}, {1}", num, str4); //меняет местами стр4 и нум
            //3. Concat
            string str6 = String.Concat("asasasasas", num);
            //4. Сложение строк
            string str7 = str6 + str5 + "asasasas";
        }
    }
}
