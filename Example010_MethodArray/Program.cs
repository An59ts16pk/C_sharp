﻿int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;    // длина или количество элементов массива
int find = 18;            // положим, что пользователь ввёл 4

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
