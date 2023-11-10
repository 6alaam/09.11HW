







double[] GetRandomArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100)*0.5;
    }
    return result;
}

void PrintArray(double[] numbers)      // распечатываем все элементы массива
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");

    }
    Console.WriteLine(" ");
}



double[] arr = GetRandomArray(5); 
PrintArray(arr);