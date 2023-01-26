//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите a");
string astring = Console.ReadLine ();
int a = Convert.ToInt32(astring) ;
Console.WriteLine("Введите число b");
string bstring = Console.ReadLine ();
int b = Convert.ToInt32(bstring) ;
Console.WriteLine("Введите число c");
string cstring = Console.ReadLine ();
int c = Convert.ToInt32(cstring) ;
int max = a;
if (b>max)
{
   max = b;
   if (c>max)
   max = c;
}
else 
{
    if (c>max)
    max=c;
}
Console.WriteLine(max);