// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int number = Prompt("Введите число");

int SumNumbers(int number)
{
    int add = 0;
    int result = 0;

    while (number > 0)
    {
        add = number % 10;
        result = result + add;
        number = number / 10;
    }
    return result;
}

int sum = SumNumbers(number);
System.Console.WriteLine("Сумма цифр в числе: " + sum);