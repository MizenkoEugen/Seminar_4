// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int length = Prompt("Введите количество элементов массива: ");
int min = Prompt("Введите минимальный порог случайных значений: ");
int max = Prompt("Введите максимальный порог случайных значений: ");

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max + 1);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

System.Console.Write($"Массив длиной {length} элементов: ");
printArray(CreateArray(length));
