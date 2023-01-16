// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(NumberMain.Numbers.EnterNumber("Введите длину массива"), 0, 9);
        ShowArray(array);
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {String.Join(", ", GetDivineArray(array))}");

    }

    static int[] CreateRandomArray(int size, int start, int end)
    {
        int[] RandomArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = new Random().Next(start, end + 1);
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

    static int[] GetDivineArray(int[] array)
    {
        int size = (array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1);
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            if (i != array.Length - i - 1)
                newArray[i] = array[i] * array[array.Length - i - 1];
            else newArray[i] = array[i];
        }
        return newArray;
    }
}