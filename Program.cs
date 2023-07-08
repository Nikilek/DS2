void Task1()
{
    /* Написать прогорамму, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
    */
    int Prompt(string msg)
    {
        Console.WriteLine("Введите трехзначное число namders");
        return Convert.ToInt32(Console.ReadLine());
    }
    int numbers = Prompt("Введите трехзначное число nambers");
    if (numbers >= 100 && numbers < 1000)
    {
        int mid = (numbers % 100 - numbers % 10) / 10;
        Console.WriteLine("второе число это " + numbers + " is " + mid);
    }
    else
    {
        Console.WriteLine("Это число не трехзначное");
    }
}


void Task2()
{
    /* Напишите программу, которая с помощью деления выводит третью цифру заданного числа или, сообщает что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    3267943297 -> 6
    */

    int numbers = ReadInt("Введите число: ");
    int count = numbers.ToString().Length;
    Console.Write(MakeArray(numbers, count));

    int ReadInt(string messege)
    {
        Console.WriteLine(messege);
        return Convert.ToInt32(Console.ReadLine());
    }
    int MakeArray(int a, int b)
    {
        int resalt = 0;
        if (b < 3)
        {
            Console.WriteLine("Трейтей цифры нет");
        }
        else
        {
            int c = 1;
            for (int i = b; i > 3; i--)
            {
                c = c * 10;
            }
            resalt = (a / c) % 10;
        }
        return resalt;
    }
}



void Task3()
{
    /* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, являеться этот день выхожным.
    6 -> да
    7 -> да
    1 -> нет
    */

    int dayNumbers = ReadInt("Введите число от 1 до 7: ");
    Console.WriteLine(WorkHoliday(dayNumbers));

    int ReadInt(string messege)
    {
        Console.Write(messege);
        return Convert.ToInt32(Console.ReadLine());
    }
    string WorkHoliday(int a)
    {
        if (a > 0 && a < 8)
        {
            if (a == 7 || a == 6)
            {
                Console.Write("Под цифрой " + a + "- Выходной ");
            }
            else
            {
                Console.Write("Под цифрой " + a + "- Рабочий ");
            }
        }
        else
        {
            Console.Write("Введенное число не соотвествует пределу от 1 до 7, по этому не определен день недели");
        }
        return "день";
    }
}


Task1();



