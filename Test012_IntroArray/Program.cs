﻿int Max(int arg1, int arg2, int arg3)   // Метод для нахождения max из 3-х чисел
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 11, 2, 377, 45, 15, 61, 17, 18, 19 };
array[0] = 12;
Console.Clear();
Console.WriteLine(array[0]);

int result = Max(Max(array[0], array[1], array[2]), 
                Max(array[3], array[4], array[5]), 
                Max(array[6], array[7], array[8]));

Console.WriteLine($"Max meaning: {result}");
