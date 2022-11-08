    //Задания к семинару 6. Одномерные массивы. Продолжение
        Start();
        void Start()
        {
            while (true)
            {
                Console.ReadLine();
                Console.Clear();

                System.Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
                System.Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
                System.Console.WriteLine("0 End");

                int numTask = SetNumber("task");

                int SetNumber(string numberName)
                    {
                    Console.Write($"Введите номер задачи {numberName}: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    return num;
                    }

                switch (numTask)
                {
                    case 0: return; break;
                    case 41: NumGreaterThanZero(); break;
                    case 43: PointIntersectionStraightLines(); break;
                    default: System.Console.WriteLine("Error"); break;
                }

            }

        }


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void NumGreaterThanZero()
{
Console.WriteLine("Введите числа (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Кол-во элементов > 0: {count}");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void PointIntersectionStraightLines()
{
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double  b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}