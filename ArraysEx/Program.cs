﻿// Двумерные массивы
// 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] Array(int m, int n) // метод создания массива
{
    int[,] Array = new int[m, n];
    return Array;
}

void PrintImage(int[,] Arr)
{

    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            Console.Write(i + 1);

        }
        Console.WriteLine();
    }
}
int[,] Arr = Array(4, 5);
PrintImage(Arr);



//49.  Показать двумерный массив размером m×n заполненный вещественными числами

// В двумерном массиве n×k заменить четные элементы на противоположные
// Задать двумерный массив следующим правилом: Aₘₙ = m+n
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// В матрице чисел найти сумму элементов главной диагонали
// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// Написать программу, которая обменивает элементы первой строки и последней строки
// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
// В прямоугольной матрице найти строку с наименьшей суммой элементов.
// Составить частотный словарь элементов двумерного массива
// Найти произведение двух матриц
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 