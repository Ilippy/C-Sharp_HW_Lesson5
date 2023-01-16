// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(10, -10, 10);
        ShowArray(array);
        array = DivineArray(array);
        ShowArray(array);



    }


    static int[] CreateRandomArray(int N, int start, int end)
    {
        int[] RandomArray = new int[N];
        for (int i = 0; i < N; i++)
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

    static int[] DivineArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++){
            array[i] *= -1;
        }
        return array;
    }

}