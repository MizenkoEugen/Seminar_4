// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Abs(int num)
{
    if (num < 0)
    {
        num = num * -1;
    }
    return num;
}

int SumNumbers(int num)
{
    int sum = 0;
    while (Abs(num) > 0)
    {
        sum = sum + Abs(num) % 10;
        num = num / 10;
    }
    return sum;
}

int number = Prompt("Введите число -> ");
int summa = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} равна {summa}");
