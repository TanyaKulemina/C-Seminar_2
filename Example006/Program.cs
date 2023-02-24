/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **вторую** цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int GetNumber ()
    {
        Console.WriteLine("Введите любое трехзначное число");
        return Convert.ToInt32(Console.ReadLine());
    }

void GetSecondDigit (int number)
    {
        int secondDigit = (number - number%10 - number/100*100) / 10;
        Console.WriteLine($"{number} -> {secondDigit}");
    }

int a = GetNumber();
GetSecondDigit(a);

