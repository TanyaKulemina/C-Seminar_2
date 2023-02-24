/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
*/

//метод, который получает случайное число
int GetRandomNumber(int leftBound, int rightBound)
{
    return new Random().Next(leftBound, rightBound + 1);
}

//метод, который убирает среднюю цифру числа
int GetResult(int number)
{
    return (number / 100 * 10) + (number % 10);
}

int number = GetRandomNumber(100, 999);
int result = GetResult(number);

Console.WriteLine($"Результат от {number} будет {result}");