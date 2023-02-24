/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да
*/
//метод получающий число с консоли
int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//метод проверки делимости числа на 7 и 23
void Check(int a)
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

int a = GetNumber();
Check(a);