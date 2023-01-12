/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end);
    return number;
}
int WriteSecondDigit (int number)
{
    int result = ((number / 10)% 10);
    return result;
}
int randomNumber = GetNumberFromRange(100,999);
int numberSecond = WriteSecondDigit(randomNumber);
Console.WriteLine($"У числа {randomNumber} второе число {numberSecond}");
