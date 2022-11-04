       //Задания к семинару 5. Функции и одномерные массивы
        Start();
        void Start()
        {
            while (true)
            {
                Console.ReadLine();
                Console.Clear();

                System.Console.WriteLine("34) Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
                System.Console.WriteLine("36) Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
                System.Console.WriteLine("38) Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
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
                    case 34: GetArrayCheckEvenNum(); break;
                    case 36: SumOddNum(); break;
                    case 38: ArrayRealNum(); break;
                    default: System.Console.WriteLine("Error"); break;
                }

            }

        }

int SetNumber(string v)
{
    throw new NotImplementedException();
}

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void GetArrayCheckEvenNum()
        {
            Console.Clear();
          
            int[] GetRandomArray(int size, int begin, int last)
            {
                int[] arr = new int[size];
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    arr[i] = random.Next(begin, last + 1);
                }
                return arr;
            }

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.Write(arr[i] + " ");
                }
            }
            int[] array = GetRandomArray(10, 100, 1000);
            PrintArray(array);
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    count++;
            }

            Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");
        }

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void SumOddNum()
{
     Console.Clear();
   
    int[]GetRandomArray(int size , int begin, int last)     
    {
        int[] arr = new int[size];
        Random random= new Random();
        for (int i = 0; i < size; i++)
            {
            arr[i]= random.Next(begin, last+1);
            }
   return arr;
    }

void PrintArray(int[] arr)
    {
    for (int i = 0; i < arr.Length; i++)
        {
        System.Console.Write(arr[i] + " ");
        }
    }
int[] array = GetRandomArray(10 , 100, 1000);
PrintArray(array); 
int sum=0;

for (int i = 0; i < array.Length; i++)
    {
    if(array[i] % 2!=0)
    sum = sum+array[i];
    }
 Console.WriteLine($"всего {array.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

}

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void ArrayRealNum()
{
     Console.Clear();
    
    Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
GetRandomArray(array);
Console.WriteLine("Mассив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"Массив состоит из {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void GetRandomArray(double[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
}

