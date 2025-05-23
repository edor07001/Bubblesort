﻿using System.Diagnostics;

int size = 100000;
int[] numbers = new int[size];
Random rng = new Random();

for(int i = 0; i < size; i++)
{
    numbers[i] = rng.Next();
}

Stopwatch sw = Stopwatch.StartNew();

BubbleSort(numbers);

sw.Stop();

for(int i = 0; i < size; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine($"Tid för sortering: {sw.Elapsed}");

static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}