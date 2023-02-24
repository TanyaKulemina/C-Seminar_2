/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

string GetNumber()
{
    Console.WriteLine("Введите любое число");
    return Console.ReadLine();
}

void GetThirdDigit(string number)
{
    if (number.Length > 2)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}

string a = GetNumber();
GetThirdDigit(a);