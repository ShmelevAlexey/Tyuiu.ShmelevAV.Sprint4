using Tyuiu.ShmelevAV.Sprint4.Task6.V15.Lib;

namespace Tyuiu.ShmelevAV.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шмелев А. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шмелев Алексей Витальевич | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Чикаго\", \"Хьюстон\", \"Феникс\",       *");
            Console.WriteLine("* \"Филадельфия\", \"Сан-Антонио\", \"Сан-Диего\", \"Даллас\"] используя  *");
            Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых меньше 7.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var city = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= city.Length - 1; i++)
            {
                Console.WriteLine(city[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество элементов, длина которых меньше 7:");

            int nums = ds.Calculate(city);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
