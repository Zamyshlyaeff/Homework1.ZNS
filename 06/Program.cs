// Написать программу вычисления значения функции y = sin(a). (Класс Math). 
Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("E = ");
            double E = double.Parse(Console.ReadLine());
            double u = x, s = x;
            int n = 1;
           while (Math.Abs(u) > E)
            {
                s += u *= -x * x / ++n / ++n;
            }
            Console.WriteLine(@$"     sin({x}) = {s}, 
Math.Sin({x}) = {Math.Sin(x)}");
            Console.ReadLine();
            
