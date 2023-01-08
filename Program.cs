class RandomArr
{
    static int GetRandomArray()
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            Random mark = new Random();
            arr[i] = mark.Next(1, 11);
            Console.Write(arr[i]);
            Console.Write(' ');
        }
        return arr;
    }

    static int FindMinMaxArrayValue(int[] array)
    {
        int min = 10, max = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return Console.WriteLine(' ', min, max);
    }

    static double FindAverageArrayValue(int[] array)
    {
        double average;
        double summ = 0;

        foreach (int element in array)
        {
            summ += element;
        }
        average = summ / ((array.Length - 1) * 1.0);
        return Console.WriteLine(average);
    }

    static int CallArray()
    {
        int[] arr = GetRandomArray();
        FindMinMaxArrayValue(arr);
        FindAverageArrayValue(arr);
        return;
    }

    static void Main()
    {
        CallArray();
    }
}