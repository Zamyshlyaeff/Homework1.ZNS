// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
int a = new Random().Next(9,1000);
int b,c;
System.Console.WriteLine($"{a}");
b=a/10;
c=b-(b/10)*10;

System.Console.WriteLine($"Вторая цифра с конца это {c}");

