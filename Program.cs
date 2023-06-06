// ______________________Задача 34___________________________________________________________________
//  Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество чётных
//  чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Ведите масив  ");
// int a = Convert.ToInt32(Console.ReadLine() );
// int[] randomArray = new int[a];

// void mas(int a)
// {
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(99,999);
// Console.Write(randomArray[i] + " ");
// }

// }

// int kol(int[] randomArray)
// {
// int kol = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
// if (randomArray[i] % 2 == 0)
// kol = kol + 1;
// }
// return kol;
// }

// mas(a);
// Console.Write($"\nКоличество чётных чисел в массиве = {kol(randomArray)}");




// _________________________________________Задача 36___________________________________________________
//  Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива:");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];
// Console.WriteLine("массив: ");

// void mas(int a)
// {
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(-9,9);
// Console.Write(randomArray[i] +  " ");
// }

// }

// int kol(int[] randomArray)
// {
// int sum = 0;
// int i = 1;
// while (i < randomArray.Length)
// {
// sum = sum + randomArray[i];
// i = i + 2;
// }
// return sum;
// }

// mas(a);
// Console.Write($"\n Cумма элементов cтоящих на нечётных позициях = {kol(randomArray)}");


//  ________________________________________Задача 38________________________________________________
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// Console.WriteLine("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[a];
//  Console.WriteLine("массив: ");
// void mas(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.NextDouble();
// Console.WriteLine($"{randomArray[i]:F2} ");
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(a);
// Console.Write($"\nРазница между максимальным и минимальным элементов массива = {raz(randomArray):F2}");


//  ________________________________________Задача 38 вариант2________________________________________________
//  Задайте массив ЦЕЛЫХ чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 42, 15, 77, 2] => 77 - 3 = 74

// Console.WriteLine("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[a];
//  Console.WriteLine("массив: ");
// void mas(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.Next(-101, 101);
// Console.WriteLine(randomArray[i] +  " ");
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(a);
// Console.Write($"\nРазница между максимальным и минимальным элементов массива= {raz(randomArray)}");
