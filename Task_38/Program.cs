// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        double[] array = CreateRandomArray(Numbers.EnterNumber("Введите длину массива"), 0, 100);
        ShowSubtractionOfMaxMinNumbers(array);
        
    }

    static double[] CreateRandomArray(int size, double start, double end)
    {
        double[] RandomArray = new double[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] =  random.NextDouble() * (end - start) + start;
        }
        return RandomArray;
    }

    static double GetSubtractionOfMaxMinNumbers(double[] array)
    {
        double[] newArray = (double[])array.Clone();
        Array.Sort(newArray);
        return newArray[^1] - newArray[0];
    }

    static double GetVarianceOfMaxMinNumbers(double[] array)
    {
        double min = array[0], max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        return max - min;
    }

    static double GetMinMaxSubtraction(double[] array)
    {
        return array.Max() - array.Min(); 
    }

    static void ShowSubtractionOfMaxMinNumbers(double[] array)
    {
        System.Console.WriteLine($"[{String.Join(", ", array)}] -> {GetVarianceOfMaxMinNumbers(array):F2} | {GetSubtractionOfMaxMinNumbers(array):F2} | {GetMinMaxSubtraction(array):F2}");
    }
}