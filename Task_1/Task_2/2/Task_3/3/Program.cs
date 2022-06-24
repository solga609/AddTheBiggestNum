//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Вести три числа и определить какое из них больше ");
        int num1, num2, num3;
        Console.WriteLine("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        bool number0 = a > b;
        bool number1 = a < b;
        bool number2 = a > c;
        bool number3 = a < c;
        bool number4 = b > c;
        bool number5 = b < c;
         
         if (a > b && a > c)
         Console.WriteLine("Number Max = " + a);
         else if (b > c)
         Console.WriteLine("Number Max = " + b);
         else
         Console.WriteLine("Number Max = " + c);