// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(8, -100, 100);
        ShowEvenNumbers(array);
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

    static void ShowEvenNumbers(int[] array)
    {
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {GetEvenNumbers(array)}");
    }

    static int GetEvenNumbers(int[] array)
    {
        int result = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            result += array[i];
        }
        return result;
    }
}