// : Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void task2()
{
    // создание массива
    int size = 8;
    int [] number = new int [size];
    Random rnd = new Random();

    // заполнение массива
    for (int i =0; i < number.Length; i++)
    {
        number[i] = rnd.Next(0, 100);
    
    }


    //вывод массива
    for (int i =0; i< number.Length; i++)
    {
        Console.Write($"{number[i]} ");
    }
    Console.WriteLine();

    // создание массива с нечетными числами

    int sum = 0;

    // проходим по всем элементам массива
        foreach (int num in number) {
            // если число нечетное, увеличиваем счетчик на 1
            if (num % 2 != 0) {
                sum+= num;
            }
        }
    // выводим количество четных чисел
            Console.WriteLine($"сумма нечетных чисел =  {sum}");
}

task2();
