/*  С клавиатуры вводятся два вещественных числа. 
Проверять является ли одно из них квадратом второго*/

double a,b;

a=Convert.ToDouble(Console.ReadLine());
b=Convert.ToDouble(Console.ReadLine());
if (b==a*a)
{
    System.Console.WriteLine("$ Число {b} является квадратом числа {a}");
}
else if  (a==b*b)
{ 
    
    System.Console.WriteLine("$ Число {a} является квадратом числа {b}");
        }
 else 
 {
    System.Console.WriteLine(" Ни одна из чисел не является квадратом другой числа ");

 }
