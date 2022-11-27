

//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

void Task25()
{
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = Convert.ToInt32(Math.Pow(a, b));
    Console.WriteLine($"{a} ^ {b} = {result}");
}



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Task27()
{
    int sum = 0;
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    Console.WriteLine($"Сумма цифр числа = {sum}");
}



//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-10, 30);
    }
}

void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
}

void Slection(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int minP = i;
        for (int j = i + 1; j < size; j++)
        {
            if (Math.Abs(nums[j]) < Math.Abs(nums[minP])) minP = j;
        }
        int temp = nums[i];
        nums[i] = nums[minP];
        nums[minP] = temp;
    }
}


int size = 8;
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
Slection(numbers);
PrintArray(numbers);
