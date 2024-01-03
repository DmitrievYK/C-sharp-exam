// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:\t");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }
    }
    static string[] FilterArray(string[] input)
    {
        int count = 0;
        // Считаем количество элементов списка не более 3
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                count++;
            }
        }
        // Новый массив с длинной 3
        string[] result = new string[count];
        int index = 0;

        //заполнение нового массива
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                result[index] = input[i];
                index++;
            }
        }
        return result;

    }
}
