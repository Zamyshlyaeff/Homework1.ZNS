// По заданному с клавиатуры номеру дня недели вывести его название
int a; // Ещё понял что можно сделать через массив, просто технически не знаю комманд
a=Convert.ToInt32(System.Console.ReadLine());
if (a==1)
{
System.Console.WriteLine("Сегодня понедельник!");
}
if (a==2)
{
System.Console.WriteLine("Сегодня вторник!");
}
if (a==3)
{
System.Console.WriteLine("Сегодня среда!");
}
if (a==4)
{
System.Console.WriteLine("Сегодня четверг!");
}
if (a==5)
{
System.Console.WriteLine("Ура пятница!");
}
if (a==6)
{
System.Console.WriteLine("Дожили до субботы!");
}
if (a==7)
{
System.Console.WriteLine("Уже воскресенье!");
}