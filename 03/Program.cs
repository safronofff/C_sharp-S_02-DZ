/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());

bool Vihodnoy(int x)
{
	if (x % 6 == 0 || x % 7 == 0) return true;
	else return false;
}

bool result = Vihodnoy(num);
if (result)
{
	Console.WriteLine("Да.Данный день является выходным");
}

else
{
	Console.WriteLine("Увы.Данный день выходным Не является, продолжайте пахать!!!");
}
