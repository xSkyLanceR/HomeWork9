// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// string GetNatural(int m, int n)
// {
//     if (m == n) return Convert.ToString(n);
//     return m + ", " + GetNatural (m + 1, n);
// }

// System.Console.WriteLine(GetNatural(4, 8));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// static int SumNumbers(int M, int N)
// {
//     if (M == 0) return (N * (N + 1)) / 2;            
//     else if (N == 0) return (M * (M + 1)) / 2;       
//     else if (M == N) return M;                       
//     else if (M < N) return N + SumNumbers(M, N - 1); 
//     else return N + SumNumbers(M, N + 1);
// }

// Console.Write("M = ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("N = ");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine($"Result, Сумма = {SumNumbers(M, N)}");
// Console.ReadLine();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
int Akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
else
{
return Akkerman(m - 1, Akkerman(m, n - 1));
}
}

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} = {akkermanFunction} ");