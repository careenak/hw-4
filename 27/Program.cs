// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int n = ReadInt("Введите число: ");
int k = Kol(n);
SumNumb(n, k);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция, которая считает количество цифр в числе
int Kol(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

// Функция вывода суммы цифр в числе
void SumNumb(int x, int kl)
{
    int sum = 0;
    for (int i = 1; i <= kl; i++)
    {
        sum += x % 10;
        x /= 10;
    }
    Console.WriteLine(sum);
}