// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Ввести два числа и определить какое из них больше.");
int num1 , num2;
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool number0 = a > b;
bool number1 = a < b;
if (number0)
{
    Console.WriteLine($"Число {a} больше чем {b} ");
}
else {
    Console.WriteLine($"Число {b} больше чем {a} ");
}
