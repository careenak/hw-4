// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A:");
   int na = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
   int nb = Convert.ToInt32(Console.ReadLine());
ToDegree(na, nb);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

