// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
  Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
 
            int max=a;
            if ((a == b) && (a == c))
            {
                Console.WriteLine("Нет максимального, числа равны");
            }
            else
            {
                if (a > b) max = a;
                else max = b;
                if (c > max) Console.WriteLine("Max = " + c);
                else Console.WriteLine("Max = " + max);
            }
 