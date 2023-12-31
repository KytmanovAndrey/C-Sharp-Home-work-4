﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 1;
    Console.Write(col[0]);
    while (position < count)
    {
        Console.Write($", {col[position]}");
        position++;
    }
    position = 1;
    Console.Write($" -> [{col[0]}");
    while (position < count)
    {
        Console.Write($", {col[position]}");
        position++;
    }
    Console.Write("]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);