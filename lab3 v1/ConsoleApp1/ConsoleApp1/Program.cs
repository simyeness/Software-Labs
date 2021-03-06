﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количество элементов в массиве: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[numbers];


            for (int y = 0; y < mass.Length; y++)
            {
                mass[y] = rand.Next(-100, 100);
                Console.WriteLine($"{y+1} элемент = {mass[y]}");
            }

            int n1 = mass[0]; int n2 = mass[1]; int n3 = mass[3]; //берем первые три как начальные максимальные
            for (int i = 0; i < mass.Length; i++) // перебираем первый
            {
                for (int j = i + 1; j < mass.Length; j++)// перебираем второй но только те которые ПОСЛЕ первого j=i+1
                                                         //те которые были до первого мы уже проверили считая их первым числом.
                {
                    for (int z = j + 1; z < mass.Length; z++) // перебирам третий после второго
                    {
                        if (mass[i] * mass[j] * mass[z] > n1 * n2 * n3) // если надо
                        {
                            n1 = mass[i]; n2 = mass[j]; n3 = mass[z]; //меняем компоненты максимального
                        }
                    }
                }
            }
            
            Console.Write("Числа, при которых произведение будет максимально:\n");
            Console.WriteLine(n1 + " " + n2 + " " + n3);
            Console.WriteLine($"Произведение: {n1 * n2 * n3}");
            Console.ReadLine();
        }
    }
}