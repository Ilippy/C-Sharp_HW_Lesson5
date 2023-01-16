// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(Numbers.EnterNumber("Введите длину массива"), 0, 100);
        ShowSubtractionOfMaxMinNumbers(array);
        
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

    static int GetSubtractionOfMaxMinNumbers(int[] array)
    {
        int[] newArray = (int[])array.Clone();
        Array.Sort(newArray);
        return newArray[^1] - newArray[0];
    }

    static int GetVarianceOfMaxMinNumbers(int[] array)
    {
        int min = array[0], max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        return max - min;
    }

    static int GetMinMaxSubtraction(int[] array)
    {
        return array.Max() - array.Min(); 
    }

    static void ShowSubtractionOfMaxMinNumbers(int[] array)
    {
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {GetVarianceOfMaxMinNumbers(array)} | {GetSubtractionOfMaxMinNumbers(array)} | {GetMinMaxSubtraction(array)}");
    }
}