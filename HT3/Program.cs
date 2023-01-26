Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
string astring = Console.ReadLine ();
double a = Convert.ToDouble (astring) ;

if (a%2 == 0)
{
   Console.WriteLine("Да");
}
else 
{
   Console.WriteLine("Нет");
   }
