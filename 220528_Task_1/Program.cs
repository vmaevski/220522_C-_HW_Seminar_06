// 1.Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountingPositivNumbers(int M)
{
    string str = "Введены числа: ";
    int num = 0;
    int amountPositiv = 0;
     for (int i = 1; i <= M; i++)
    {
        Console.Write($"Введите {i}-е число: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            amountPositiv++;
        }
        str += ($" {num.ToString()},");
    }
    Console.WriteLine(str);
    Console.WriteLine($"из них {amountPositiv} положительных.");
}

CountingPositivNumbers(10);