// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumberMN(int x, int y, int sum)
{
    if (x < y) return sum += x + SumNaturalNumberMN(x+1, y, sum);
    else return y;
}

Console.Clear();
Console.WriteLine("Введите значение M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел в промежутке от {number1} до {number2} составит: ");
Console.Write(SumNaturalNumberMN(number1, number2, sum: 0));