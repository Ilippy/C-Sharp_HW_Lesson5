// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


internal partial class Program
{
    private static void Main(string[] args)
    {
        int findNumber = NumberMain.Numbers.EnterNumber("Введите число в пределах[0,20], которое вы будете искать в массиве", 0, 20);
        int[] array = CreateRandomArray(10, 0, 20);
        ShowArray(array);
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> "+ (IsNumberExsist(array, findNumber) ? "да" : "нет"));
    }

    static int[] CreateRandomArray(int size, int start, int end)
    {
        int[] RandomArray = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = random.Next(start, end + 1);
        }
        return RandomArray;
    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static bool IsNumberExsist(int[] array, int number)
    {
        foreach (int item in array)
        {
            if (item == number) return true;
        }
        return false;
    }
}