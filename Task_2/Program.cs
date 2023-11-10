// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с
// нечётными индексами








void FillArray(int[] numbers, int minValue = -10,int maxValue = 100 )
{


    Random rnd = new Random();
    maxValue++;
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }

}


void PrintArray(int[] numbers)      // распечатываем все элементы массива
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");

    }
    Console.WriteLine(" ");
}


int SumOddIndex(int[] numbers){

    int summa = 0;
    for (int i = 1; i < numbers.Length; i+=2)
    {
        summa+= numbers[i];
    }
    return summa;

}




int[] array = new int[6];

FillArray(array,1,5);
PrintArray(array);
System.Console.WriteLine($"сумма элементов с нечетным индексом {SumOddIndex(array)}");

