//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void task1()
{
// создание массива
int size = 4;
int [] number = new int [size];
Random rnd = new Random();

// заполнение массива
for (int i =0; i < number.Length; i++)
{
    number[i] = rnd.Next(100, 1000);
   
}


//вывод массива
for (int i =0; i< number.Length; i++)
{
    Console.Write($"{number[i]} ");
}
Console.WriteLine();

// создание массива с четными числами

int count = 0;

 // проходим по всем элементам массива
    foreach (int num in number) {
        // если число четное, увеличиваем счетчик на 1
        if (num % 2 == 0) {
            count++;
        }
     }
// выводим количество четных чисел
        Console.WriteLine("Количество четных чисел: " + count);
}

task1();

