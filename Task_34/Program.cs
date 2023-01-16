// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(8, 100, 999);
        ShowOddsNumbers(array);
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

    static int GetOddsNumbers(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0) result++;
        }
        return result;
    }

    static void ShowOddsNumbers(int[] array){
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {GetOddsNumbers(array)}");
    }
}