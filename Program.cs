//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}
Console.Write("input a number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int secondNumber = SecondNumber(num3);
Console.WriteLine($"number {secondNumber}");
*/

//Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).


/*
int ThirdNumber(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result; 
}
Console.Write("input a number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
int thirdNumber  = ThirdNumber(num4);
Console.WriteLine($"number {num4} ThirdNumber {thirdNumber}");
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayOfTheWeek(int num)
{
    return num >= 6;
}
int randDay = new Random( ).Next(1,8);
bool Day = DayOfTheWeek(randDay);
if(Day) Console.Write($"{randDay} yes");
else Console.Write($"{randDay} no");
*/