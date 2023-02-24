/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
//метод получения чисел с консоли 

int GetNumber()
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

//метод проверки числ на кратность
void Kratnost (int a, int b)
    {
        int ostatok = 0;
        if (a % b == 0)
        {
            Console.WriteLine("кратно");
        }
        else
        {
            ostatok = a % b;
            Console.WriteLine($"не кратно, остаток {ostatok}");
        }
    }

//запускаем методы
int a = GetNumber();
int b = GetNumber();
Kratnost(a, b);
