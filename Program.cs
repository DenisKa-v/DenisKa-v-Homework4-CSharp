// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
/* 
int Exponentiation (int a, int b)
 {
    int multi = 1;
    int count = 1;
    while (count <= b)
    {
        count ++;
        multi = multi * a;
    }
    return multi;
 }

Console.Write("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input natural number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {a} to the extent {b} is {Exponentiation(a, b)}");
 */
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* 
int SumOfDigits (int num)
{
    int sum = 0;
    int count = 0;

    if (num < 0) num = -num;
    while (num > 0)
    {
        count ++;
        sum = sum + num%10;
        num = num/10;
       
    }
    return sum;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits in {number} is {SumOfDigits(number)}");
 */
//Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
/* 
int [] CreatRandArray (int n, int minVal, int maxVal)
{
    int [] arr = new int [n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal,maxVal);
    }
    return arr;
}

void PrintArray (int [] arr)
{
    Console.Write("Array: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
}

Console.Write("Input the positive integer number of array elements: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
    PrintArray (CreatRandArray (number,1,99));
else
    Console.WriteLine($"Your number: {number}, does not match the condition of the problem, try again");
 */
 