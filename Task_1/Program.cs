// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Degree(int a, int b)
{
    int deg = 1;
    for (int i = 1; i <= b; i++)
    {
        deg = deg * a;
    }
    return deg;
}

int numA = Prompt("Введите число A -> ");
int numB = Prompt("Введите число B -> ");

Console.WriteLine($"Число {numA} в натуральной степени {numB} равно {Degree(numA, numB)}");
