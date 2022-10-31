/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/* int GetNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result = result * a;
    {
        double grade = Math.Pow(a, b);
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int getnumber = GetNumber(a, b);
Console.WriteLine("Ответ: " + getnumber); */

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int getnumber = a;

for (int i = 1; i < b; i++)
{
    getnumber = getnumber * a;
}
Console.WriteLine($"{a} в степени {b} равно: {getnumber}");