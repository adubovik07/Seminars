/*
Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
/

Console.Clear();

Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());

if (a < 8)
{
    if (a == 1)
    {
        Console.WriteLine("Понедельник");
    }

    else
    {
        if (a == 2)
        {
            Console.WriteLine("Вторник");
        }

        else
        {
            if (a == 3)
            {
                Console.WriteLine("Среда");
            }

            else
            {
                if (a == 4)
                {
                    Console.WriteLine("Четверг");
                }

                else
                {
                    if (a == 5)
                    {
                        Console.WriteLine("Пятница");
                    }

                    else
                    {
                        if (a == 6)
                        {
                            Console.WriteLine("Суббота");
                        }
                        
                        else
                        {
                            Console.WriteLine("Воскресенье");
                        }
                    }
                }
            }
        }
    }      
}
else
{
    Console.WriteLine("Вы придумали новый день недели - Бездельник)))");
}


Задача No5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"


Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());
int a = -N;

while (a <= N)
{
    Console.Write($"{a}, ");
    a = a + 1;
}

Задача No7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
*/

Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());

if (a < 1000 & a > 99)
{
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число(");
}