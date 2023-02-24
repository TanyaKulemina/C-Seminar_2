/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

78 --> 8
85--> 8
*/

//метод, который получает случайное число
int GetRandomNumber(int leftBound, int rightBound)
{
    int result = 0;
    result = new Random().Next(leftBound, rightBound + 1);
    return result;
}

//метод, который получает максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");