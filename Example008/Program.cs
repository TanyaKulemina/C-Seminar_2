/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int GetNumber ()
    {
        Console.WriteLine("Введите число");
        return Convert.ToInt32(Console.ReadLine());
    }

void GetDay (int a)
    {
        if (a == 1 || a == 2 || a == 3 || a == 4 || a == 5)
        {
            Console.WriteLine("нет");
        }
        else if (a == 6 || a == 7)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("такого дня нет");
        }
    }
    int a = GetNumber();
    GetDay (a);