
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.Write("Введите число a , которое возведем в степень: ");
// a = Convert. ToDouble(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b, оно будет возводить в степень число a: ");
// b = Convert. ToDouble(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
for (c = (int)Math.Pow(a, b);;)
{ Console.WriteLine("Число a^b равно c"); }
