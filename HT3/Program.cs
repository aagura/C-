 //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


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
