// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Будет создан массив длиной 8");
            int n = 8;
            SumNumb(n);
      
            void SumNumb (int x)
            {
                 int[] array = new int[x];
            for (int i = 0; i < x; i++)
            {
                array[i] = new Random().Next(x+1);
                Console.Write(array[i] + "; ");

            }
            Console.WriteLine();
                int sum = 0;
                for (int j = 0; j < x; j++)
                {
                  sum += array [j];
                }
                Console.WriteLine("Сумма всех чисел массива: "+ sum);
            }
            