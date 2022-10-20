/*Рекурсия - функция, которая вызывает сама себя. Есть шутка: чтобы понять рекурсию,
нужно понять рекурсию. */

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*Console.WriteLine("Input N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;

Console.WriteLine(Natural(n, a));

int Natural (int n, int a)
{
        if (n == a)
        {
            return n;
        }
        else
        {
            Console.Write(Natural(n, a+1) + ", ");
        }
        return a;
}*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Input N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Input M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма элементов от "+ n +" до " + m + ": " + Sum(n, m));

int Sum(int n, int m)
{
    if (n==m) return m;
    return m + Sum(n,m-1);
}

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
