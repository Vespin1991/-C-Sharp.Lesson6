//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[M];
int count = 0; 
    for (int i = 0; i < M; i++)
{
    Console.Write("Введите число   ");
    massiv[i] = Convert.ToInt32(Console.ReadLine()); 
    
              if (massiv[i]>0)
               {count = count + 1;
}  }
Console.WriteLine($"Колличество чисел больше нуля равно {count}");