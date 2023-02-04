// Удалить вторую цифру целого числа введенного с клавиатуры.
int a,b,c,d;
a=Convert.ToInt32(System.Console.ReadLine());
b=a/10;
c=b-b/10;
if (a>100)
{
d=a-c*10;
System.Console.WriteLine($"{d}");
}
else
{
    d=a/10;
    System.Console.WriteLine($"{d}");
}