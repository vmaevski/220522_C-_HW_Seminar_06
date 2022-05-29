﻿// 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Решаем систему уравнений:
// k1*x + b1 = k2*x + b2
// k1*x - k2*x = b2 - b1
// x*(k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2) -координату X нашли, подставим её в любое уравнение, на пример, в 1-е

void IntersectionPoint(int k1, int b1, int k2, int b2)
{
    if (k1 == k2 && b1 == b2){
        Console.WriteLine("Прямые совпадают.");    
    }
    else if (k1 == k2) {
        Console.WriteLine("Прямые параллельны.");    
    }
    else{
        int x = (b2 - b1) / (k1 - k2);
        int y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения: X = {x}, Y = {y}.");
    }
}

Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());

IntersectionPoint(k1, b1, k2, b2);