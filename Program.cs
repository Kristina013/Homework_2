// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int second_num (int number)
{
    int num_23 = number % 100;
    int num_3 =  number % 10;

    int num_2 = (num_23-num_3) / 10;

    return num_2;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)
{
    int number_2 = second_num (num);
    Console.WriteLine($"Second number is " + number_2);
}
else
{
    Console.WriteLine($"Impossible value!");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6d

/*
int func (int num, int poryadok, int delitel_1, int delitel_2)
{
    int third_num = 0;

    if(num < poryadok)
    {
        third_num = num % delitel_1 / delitel_2; 
    }
    else
    {
        poryadok = poryadok * 10;
        delitel_1 = delitel_1 * 10;
        delitel_2 = delitel_2 * 10;
        third_num = func (num, poryadok, delitel_1, delitel_2);
    }   
    return third_num;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine($"Третьей цифры нет!");
}
else
{
    int poryadok = 1000;
    int delitel_1 = 10;
    int delitel_2 = 1;
    int third_num = func (num, poryadok, delitel_1, delitel_2);
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
int day (int num)
{
    int week_day;
    if(num >= 1 && num <= 5)
    {
        week_day = 1;
    }
    else
    {
        week_day = 2;
    }
    return week_day;
}

Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <= 7)
{
    int week_day = day (num);
    if(week_day == 1)
    {
        Console.WriteLine($"Нет");
    }
    else
    {
        Console.WriteLine($"Да");
    }   
}
else
{
    Console.WriteLine($"Введите значение от 1 до 7");
}
*/