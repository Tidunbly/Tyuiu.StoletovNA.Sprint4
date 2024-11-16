using Tyuiu.StoletovNA.Sprint4.Task1.V13.Lib;
namespace Tyuiu.StoletovNA.Sprint4.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Столетов Никита Андреевич | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы. (Ввод с клавиатуры)                                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПБ-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный значениям*");
            Console.WriteLine("*ми с клавиатуры в диапазоне от 0 до 8 подсчитать сумму четных элементов м*");
            Console.WriteLine("*массива.                                                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i} значение массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            foreach (int numb in array)
            {
                Console.WriteLine(numb);
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