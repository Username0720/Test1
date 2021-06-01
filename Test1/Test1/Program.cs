using System;
using System.Threading;

namespace Test1
{
    class Program
    {
        /// <summary>
        /// метод для вывода массива
        /// </summary>
        static void Show(int[] arr)
        {
            foreach (int c in arr)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char ch = 'y';
            while (ch == 'y')
            {
                int max = 0;
                bool check = false;//флажок для учета четных элементов стоящих на нечетных местах
                int n = 10;

                bool accepted = false;
                while (!accepted)
                {
                    Console.Write("Введите размерность массива: ");
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                        accepted = true;
                    }
                    catch (Exception e)
                    { Console.WriteLine("Введите целое значение.", e); }

                }

                int[] start_array = new int[n];
                int[] change_array = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < start_array.Length; i++)
                {
                    start_array[i] = rnd.Next(100);
                    change_array[i] = start_array[i];
                    if (change_array[i] % 2 == 0 && i % 2 == 0)
                    {
                        check = true;
                        change_array[i] *= 2;
                    }
                    if (start_array[i] % 2 != 0 && i % 2 == 1)
                        if (max < start_array[i]) 
                            max = start_array[i];
                }
                Console.WriteLine("Исходный массив натуральных чисел: ");
                Show(start_array);
                Console.WriteLine(" - Преобразованный массив");
                Show(change_array);
                Console.WriteLine($"Максимальное значение из нечетных элементов стоящих на четных местах - {max}");
                if (check == false)
                    Console.WriteLine("В массиве не оказалось ни одного четного элемента стоящего на нечетном месте");

                Console.WriteLine("Нажмите - y, чтобы попробовать заново, другую, чтобы выйти.");
                ch = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}

