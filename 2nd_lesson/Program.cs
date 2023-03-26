/*
int a = 5;
int b = 6;

int c = 7;
int d = 8;

int result = c * (c * d) - 5;

int result1 = Calculate(a, b);
Show (a, b);

int result2 = Calculate(c, d);
Show (c, d);

Console.WriteLine(result1);
Console.WriteLine(result2);

int Calculate(int a, int b)
{
    return a * (a * b) - 5;
}

void Show(int a, int b)
{
    Console.WriteLine($"{a}, {b}");
}

Задача 1

Random random = new Random();
int randomValue = random.Next(10, 100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);

if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}

 Задача 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98

Задача3. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно

Random random = new Random();
int randomValue = random.Next(100, 1000);

int firstDigit = randomValue / 100;
int firstTwoDigits = firstDigit * 10;
int lastDigit = randomValue % 10;

Console.WriteLine(randomValue);
Console.WriteLine(firstTwoDigits + lastDigit);

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

int result = number2 % number1;

if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(result);  
    Console.WriteLine("Не кратно");
}

Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine($"{number} -> да");
}
else{
    Console.WriteLine($"{number} -> нет");
}

Задача No16. Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a == b * b | b == a * a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 */

