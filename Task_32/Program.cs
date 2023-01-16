// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = CreateRandomArray(5, -10, 10);
        Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", DivineArray(array))}]");
        
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



    static int[] DivineArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++){
            array[i] *= -1;
        }
        return array;
    }

}