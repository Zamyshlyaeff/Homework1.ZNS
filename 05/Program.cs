// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c,max ;
a=Convert.ToInt32(System.Console.ReadLine());
b=Convert.ToInt32(System.Console.ReadLine());
c=Convert.ToInt32(System.Console.ReadLine());
max=a;
if (max<b)
{
 max=b;   
}
if (max<c)
{
    max=c;
}
System.Console.WriteLine($"Максимальное число найдено и равно {max}");