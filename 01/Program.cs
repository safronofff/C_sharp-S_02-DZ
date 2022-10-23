/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int SecondNumber(int x)
{
	int y = (x / 10) % 10;
	return y;
}

Console.WriteLine("Введите 3-х значное число:");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(num);
Console.WriteLine(result);