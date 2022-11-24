//домашнее задание 1 семинар.

//задача 2.Напишите прогрмамму, которая на вход принимает два числа и выдаёт, какое число больше,а какое меньше.

int numberA=5;
int numberB=7;
int numberA1=2;
int numberB1=10;
int numberA2=-9;
int numberB2=-3;

if ((numberA)>(numberB))
{
Console.WriteLine($"{numberA}>{numberB}");
}
else
{
    Console.WriteLine($"{numberB}>{numberA}");
}
if ((numberA1)>(numberB1))
{
Console.WriteLine($"{numberA1}>{numberB1}");
}
else
{
    Console.WriteLine($"{numberB1}>{numberA1}");
}
if ((numberA2)>(numberB2))
{
Console.WriteLine($"{numberA2}>{numberB2}");
}
else
{
    Console.WriteLine($"{numberB2}>{numberA2}");
}


// задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
int numberA=2;
int numberB=3;
int numberC=7;
int max=7;

int numberA1=44;
int numberB1=4;
int numberC1=78;
int max1=78;

int numberA2=22;
int numberB2=3;
int numberC2=9;
int max2=22;
if (numberA>=max)
{
    Console.WriteLine ("numberA-максимальное число");
}
else
if (numberB>=max)
{
Console.WriteLine ("numberB-максимальное число");
}
else
if (numberC>=max)
{
    Console.WriteLine ("numberC-максимальное число");
}
if (numberA1>=max1)
{
    Console.WriteLine ("numberA1-максимальное число");
}
else
if (numberB1>=max)
{
Console.WriteLine ("numberB1-максимальное число");
}
else
if (numberC1>=max)
{
    Console.WriteLine ("numberC1-максимальное число");
}
if (numberA2>=max2)
{
    Console.WriteLine ("numberA2-максимальное число");
}
else
if (numberB2>=max)
{
Console.WriteLine ("numberB2-максимальное число");
}
else
if (numberC2>=max)
{
    Console.WriteLine ("numberC2-максимальное число");
}


//задача 6. Напишите программу, которая на вход принимает число и выдает,является ли число чётным(делится ли оно на 2 без остатка)

int numberA=4;
int numberF=-3;
int numberK=7;
if (numberA%2>0)
{
    Console.WriteLine ("numberA является не четным числом");
}
else
{
    Console.WriteLine ("numberA является четным числом");
}
if (numberF%2>0)
{
    Console.WriteLine ("numberF является четным числом");
}
else
{
    Console.WriteLine ("numberF является четным числом");
}
if (numberK%2>0)
{
    Console.WriteLine ("numberK является не четным числом");
}
else
{
    Console.WriteLine ("numberK является четным числом");
}


// Напишите программу которая на вход принимает число (N>0) а на выходе показывает все четные числа от 1 до N

Console.WriteLine("введите любое число N");
int N =Convert.ToInt32(Console.ReadLine());

for (int i = 1;i <=N; i++)
if(i % 2 == 0)
{
Console.Write(i + ";");
}
