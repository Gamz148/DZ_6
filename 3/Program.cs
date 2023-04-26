// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95

void FillArray(double[] arr)
{
    double[] num = new double[5];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = Math.Round(rand.NextDouble() * 200 - 100, 2);
        //Console.Write($"{arr[i]}  ");
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}



void task3()
{
    int size = 5;
    double[] arr = new double[size];
    FillArray(arr);
    PrintArray(arr);
    
    double maxElem = arr.Max(); // находим максимальный элемент
    double minElem = arr.Min(); // находим минимальный элемент
    double diff = maxElem - minElem; // вычисляем разницу
    Console.WriteLine($" разница между max ({maxElem}) и min ({minElem}) элементами равна: {diff}");  
}

task3();
