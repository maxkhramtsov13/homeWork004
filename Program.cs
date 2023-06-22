/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
#region 
int ImputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int ConversionToPower(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
       result = result * number; 
    }
    return result;
}
int num = ImputNumber(" Введите целое число: ");
int deg = ImputNumber(" ведите степень числа: ");
int numDeg = ConversionToPower(num, deg);
System.Console.Write(" Степень числа " + numDeg);
#endregion

/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
#region 
int EnterNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int SumNumber(int number)
{
    int result = 0;
    for (int i = 0; i < number; i++)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int numb = EnterNumber(" Введите целое число: ");
int sum = SumNumber(numb);
Console.WriteLine(" Сумма цифр числа " + sum);
#endregion

/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
#region 
int ArrayLength(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[] GetArray(int array)
{
    int[] arr = new int[array];
    for (int i = 0; i < arr.Length; i++)   
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i] > i) 
         Console.Write($"{array[i]}, "); 
       else
        Console.Write($"{array[i]}. ");
    }
}
int arrLen = ArrayLength(" Введите длину массва: ");
int[] myArr = GetArray(arrLen);
PrintArray(myArr);
#endregion