// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(123, 0, 200);
        ShowArray(array);
        System.Console.WriteLine($"В рандомном массиве из 123 элементов найдено {GetNumberInRange(array, 10, 99)} элементов в значения которых лежат в отрезке [10,99]");
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

    static int GetNumberInRange(int[] array, int min, int max)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= min && array[i] <= max) result++;
        }
        return result;
    }



    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[array.Length - 1]);
        Console.WriteLine();
    }

}