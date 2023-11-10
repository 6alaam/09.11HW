// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.




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

int EvenNumbers(int[] numbers ){
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]%2 == 0) count++;
        
    }
    return count;
}

int[] array = new int[10];

FillArray(array,100,999);
PrintArray(array);

System.Console.WriteLine($"колличество четных чисел {EvenNumbers(array)}");
