// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Для решения задания использование цикла for является обязательным условием.

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int GetResult(int number)
{
    int result = 0;

    for (int i = 1; i <= number; i++)
    {
        result = result + (number % 10);
        number = number / 10;
    }
    return result;
}

int result = GetResult(number);
Console.WriteLine(result);