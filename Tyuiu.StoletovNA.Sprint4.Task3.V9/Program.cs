using Tyuiu.StoletovNA.Sprint4.Task3.V9.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (статический ввод)                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                            *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статичес*");
            Console.WriteLine("*скими значениями в диапазоне от 3 до 9. Найдите сумму элементов во втором*");
            Console.WriteLine("*м столбце массива.                                                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = { { 9, 6, 4, 5, 3 },
                             { 7, 4, 7, 5, 3 },
                             { 8, 5, 9, 9, 3 },
                             { 7, 8, 7, 9, 3 },
                             { 3, 7, 3, 7, 7 } };

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            Console.WriteLine("Массив: ");
            for (int i  = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}