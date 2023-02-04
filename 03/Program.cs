// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
double a,b;
a=Convert.ToDouble(System.Console.ReadLine());
b=Convert.ToDouble(System.Console.ReadLine());
if (a<b)
{
    System.Console.WriteLine($"{b} больше чем {a}");
}
if (b<a)
{
   System.Console.WriteLine($"{a} больше чем {b}"); 
}
