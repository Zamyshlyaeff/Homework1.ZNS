// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int a;
int b;
int c;
a=Convert.ToInt32(System.Console.ReadLine());
b=(a/10);
c=a-(b*10);
System.Console.WriteLine($"Последняя цифра числа {a} это {c}");

