// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void nat(int n)
// {
// if ( n == 0)
// return;
// if(n>1)
// Console.Write($"{n}, ");
// else{
//     Console.Write($"{n}");
// }
// nat(n - 1);

// }
// if (n>0) nat(n);
//*****************************************************
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int summa(int m, int n)
// {
// if (m==n)
// return n;
// else return m + summa(m + 1, n);
// }
// if(m<n){
// Console.Write($"Сумма от M до N = {summa(m,n)}");
// }
// else{
//     Console.Write($"M {m} > N {n}, данные не корректны");

// }
//************************************************************
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите значение M >= 0 : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N >= 0 : ");
int n = Convert.ToInt32(Console.ReadLine());

int akman(int m, int n)

{
  
if (m == 0) return n + 1;
else if (n == 0) return akman(m  - 1, 1);
else return akman(m - 1, akman(m, n - 1));
}
if(m >=0 && n>=0) Console.Write($"A(m,n) = {akman(m, n)} ");
else Console.Write($"M {m} или N {n} не корректны");