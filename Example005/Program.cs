/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

//метод получающий число с консоли
int GetNumber()
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

//метод проверки
void Check (int a, int b)
    {
        if (a * a == b || b * b == a) 
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }

int a = GetNumber();
int b = GetNumber();
Check(a, b);