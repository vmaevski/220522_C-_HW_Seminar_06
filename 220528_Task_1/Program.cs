// 1.Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Entering and counting numbers

// int EnteringNumbers(int count){
void CountingPositivNumbers(int amount)
{
    string str = "Введееные числа: ";
    double num = 0;
    int amountPositiv = 0;
    for (int i = 1; i <= amount; i++)
    {
        Console.WriteLine($"Введите число номер {i}:");
        num = Console.ReadLine().;
        if (num > 0)
        {
            amountPositiv++;
        }
        str += ($" {Math.Round(num, 0).ToString()}");
    }
    Console.WriteLine(str);
}

CountingPositivNumbers(10);