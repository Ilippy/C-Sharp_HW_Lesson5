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


    static int[] CreateRandomArray(int N, int start, int end)
    {
        int[] RandomArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = new Random().Next(start, end + 1);
        }
        return RandomArray;
    }

    static int GetNumberInRange(int[] array, int min, int max)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] >= min && array[i] <= max) result++;
        }
        return result;
    }

    // int[] CreateArray()
    // {
    //     Console.WriteLine("Введите количество элементов массива");
    //     int size = Convert.ToInt32(Console.ReadLine());
    //     int[] array = new int[size];
    //     for (int i = 0; i < size; i++)
    //     {
    //         Console.WriteLine($"Введите {i + 1} элемент массива");
    //         array[i] = Convert.ToInt32(Console.ReadLine());
    //     }
    //     return array;
    // }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}