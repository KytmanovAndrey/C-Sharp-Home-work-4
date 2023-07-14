// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetSumOfDigits(int number)
{
    int sum = 0;
    int temp = number;
    while (number > 0)
    {
    sum = sum + number % 10;
    number /= 10;
    }
    Console.WriteLine($"{temp} -> {sum}");
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetInput("Введите число : ");
GetSumOfDigits(number);