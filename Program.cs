// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string numText = Console.ReadLine();

// int numLength = numText.Length;

// while (numLength == 5)
// {
//     if (numText[0] == numText[4] && numText[1] == numText[3])
//     {
        
//         Console.WriteLine($"{numText} - Палиндром");
//     } else {
//         Console.WriteLine($"{numText} - Не палиндром");
//     }
//     return;
// }
// Console.WriteLine($"{numText} - Введите 5 чисел!");
// ____________________________________________________________________________________________


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите число: ");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt((Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2)));

// Console.WriteLine(d);
// ____________________________________________________________________________________________


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count<= num)
// {
//     Console.Write(Math.Pow(count,3)+" ");
//     count = count + 1;
// }
