// Выяснить является ли число чётным.
int a;
a=Convert.ToInt32(System.Console.ReadLine());
bool odd=a%2==0;
if (odd==true)
{
System.Console.WriteLine($"Число {a} является чётным");
}
else
{
    System.Console.WriteLine($"Число {a} является нечётным");
}
