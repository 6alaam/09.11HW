// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] numbers )
{


    Random rnd = new Random();
    
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.NextDouble()+rnd.Next(10,50);
        
    }

}


void PrintArray(double[] numbers)      // распечатываем все элементы массива
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");

    }
    Console.WriteLine(" ");
}

double MaxElement (double [] numbers){
  double  max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]> max){
            max = numbers[i];
        }
       
        
    }  return max;
}


double MinElement (double [] numbers){
  double  min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]< min){
            min = numbers[i];
        }
       
        
    }  return min;
}

double[] array = new double[5];


FillArray(array);
PrintArray(array);
double diff = MaxElement(array)-MinElement(array);

System.Console.WriteLine($"максимальный элемент {MaxElement(array)}");

System.Console.WriteLine($"максимальный элемент {MinElement(array)}");
System.Console.WriteLine(diff);
