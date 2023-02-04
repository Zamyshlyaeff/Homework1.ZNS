/*С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b,
 если нет, вывести остаток от деления a на b.*/
double a,b;
double c;
a=Convert.ToInt32(System.Console.ReadLine());
b=Convert.ToInt32(System.Console.ReadLine());
bool odd=b%a==0;
if (odd==true)
{
    System.Console.WriteLine($"{a} кратно {b}");
}
else
{
    c=b%a;
    System.Console.WriteLine($" {c}");
}