/* С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, 
что её нет (Вывести: NO)*/
int a;
a=Convert.ToInt32(System.Console.ReadLine());
if (a>=100)
{
    a=a-a/10*10;
    System.Console.WriteLine($"{a}");

}
else 
{
    System.Console.WriteLine("NO");
}
