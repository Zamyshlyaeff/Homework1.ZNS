/* С клавиатуры вводится целое число из  диапазона  [10, 99]. 
Показать наибольшую цифру числа*/
int a,b,c;
a=Convert.ToInt32(System.Console.ReadLine());
b=a/10;
c=a-(b*10);
if (b>c)
{
    System.Console.WriteLine($"Число {b} больше чем {c}");
}
if (b<c)
{
    System.Console.WriteLine($"Число {b} меньше чем {c}");
}
if (b==c)
{
    System.Console.WriteLine($"Числа {b} и {c} равны");
}