Console.OutputEncoding = System.Text.Encoding.UTF8;
void task1()
{
    int x1;
    x1 = 100;
    Console.WriteLine($"Value of variable x1 is: {x1}");
}
void task2()
{    
    string str1;

    // ask user a name
    Console.WriteLine("Ваше ім'я?");
    // read and save a name
    str1 = Console.ReadLine();
    
    string str2 = "Дорий день, " + str1;
    // greet user
    Console.WriteLine(str2);
}
void task3()
{
    var v1 = 'v';
    // change v1
    v1 = '@';

    Console.WriteLine($"v1: {v1}");
}
void task4(double sideOfSquare)
{
    double perimeter = sideOfSquare * 4;
    Console.WriteLine($"Периметр квадрата зі стороною {sideOfSquare} дорівнює: {perimeter}");
}
void task5(int x, int y)
{
    double average = (x + y) / 2.0;
    Console.WriteLine($"Середнє арифметичне {x} та {y}: {average}");
}
void task6(double R1, double R2)
{
    double pi = 3.14;

    // formula: S = pi * r^2
    double S1 = pi * R1 * R1;
    double S2 = pi * R2 * R2;

    // The area of a ring can be found
    // by subtracting the area of the inner circle
    // from the area of the outer circle.
    double S3 = S2 - S1;

    Console.WriteLine($"Площа круга S1: {S1}");
    Console.WriteLine($"Площа круга S2:: {S2}");
    Console.WriteLine($"Площа круга S3:: {S3}");
}
void task7(int num)
{
    // 15 / 10 = 1
    int leftDigit = num / 10;
    // 15 % 10 = 5
    int rightDigit = num % 10;

    Console.WriteLine($"Ліва цифра: {leftDigit}");
    Console.WriteLine($"Права цифра: {rightDigit}");
}
void task8(int N)
{
    // 3600 seconds in one hour
    int hours = N / 3600;
    Console.WriteLine($"Кількість повних годин з початку доби: {hours}");
}
void task9(int A, int B, int C)
{
    bool isBetween = (B > A && B < C);

    if (isBetween)
    {
        Console.WriteLine("Число В знаходиться між числами А і С");
    } else
    {
        Console.WriteLine("Число В \"НЕ\" знаходиться між числами А і С");
    }
}
void task10(int num)
{
    bool isOdd = num % 2 != 0;
    bool isThreeDigit = num > 99 && num < 1000;

    if (isOdd && isThreeDigit)
    {
        Console.WriteLine("ЧИсло є непарним та тризначним");
    }
    else
    {
        Console.WriteLine("Число \"НЕ\" є непарним та тризначним");
    }
}
void task11()
{
    int num1 = 58, num2 = 122;

    long sum = (long)num1 + num2;
    Console.WriteLine($"Сума змінних num1 і num2:{sum}");
}
void task12()
{
    long num1 = 123123123L, num2 = 859305899L;

    byte product = (byte)(num1 * num2);

    Console.WriteLine($"Добуток змінних num1 і num2: {product}");
}

void banner(string msg, string delimetr = "############################")
{
    Console.WriteLine($"\n{delimetr}\n{msg}\n");
}

banner("Task 1");
task1();
banner("Task 2");
task2();
banner("Task 3");
task3();
banner("Task 4");
task4(3.753);
banner("Task 5");
task5(5, 10);
banner("Task 6");
task6(15, 18);
banner("Task 7");
task7(68);
banner("Task 8");
task8(18956);
banner("Task 9");
task9(10, 8, 9);
banner("Task 10");
task10(483);
banner("Task 11");
task11();
banner("Task 12");
task12();