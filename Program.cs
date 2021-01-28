using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.з__3_Alif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2,1
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = a+1; i < b; i++)
            //{
            //    sum+=i;
            //}
            //Console.WriteLine($"Сумма всех чисел расположенными между А и В: {sum}");

            //for (int i = a+1; i < b; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //------------------------------------------------------------------------------------------------------


            //Задание 3,1
            //Прямоугольник
            int width = 10;
            int height = 4;

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("");

                for (int j = 0; j < width; j++)
                {
                    if (i > 0 && j > 0)
                    {
                        if (i < height - 1 && j < width - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write('*');
                        }
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();



            //Прямоугольный треугольник

            int height1 = 5;
            int width1 = 6;
            for (int i = 1; i <= height1; i++)
            {
                for (int j = 1; j < width1; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("* ");
                    }
                    else if (i == height1 && j != 1)
                    {
                        Console.Write("* ");
                    }
                    else if (i == j && i != 1)
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //ровносторонний треугольник

            int a1 = 7;
            int b1 = 8;
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < b1; j++)
                {
                    if (i == 4 && j % 2 == 1)
                        Console.Write("* ");
                    else if (i == 1 && j == 4)
                        Console.Write("* ");
                    else if (i == 2 && (j == 3 || j == 5))
                        Console.Write("* ");
                    else if (i == 3 && j == 2)
                        Console.Write("* ");
                    else if (i == 3 && j == 6)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }




            //Ромб
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == 2 && j == 5)
                        Console.Write("* ");
                    else if (i == 3 && (j == 4 || j == 6))
                        Console.Write("* ");
                    else if (i == 4 && (j == 3 || j == 7))
                        Console.Write("* ");
                    else if (i == 5 && (j == 2 || j == 8))
                        Console.Write("* ");
                    else if (i == 6 && (j == 3 || j == 7))
                        Console.Write("* ");
                    else if (i == 7 && (j == 4 || j == 6))
                        Console.Write("* ");
                    else if (i == 8 && j == 5)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            //-----------------------------------------------------------------------------------------------



            //Задание 4,1
            //double percent = double.Parse(Console.ReadLine());
            //int month = 0;
            //double investments = 1000;

            //while (1100 >= investments)
            //{
            //    investments += (investments * percent / 100);
            //    month++;
            //}
            //Console.WriteLine("Результат годового вложения = " + investments);
            //Console.WriteLine("Результат месячного вложения = " + month);


            //--------------------------------------------------------------------------------------------------------


            //Задание 2,2

            //int size = int.Parse(Console.ReadLine());
            //int[] myArray = new int[size];

            //Random rnumbers = new Random();
            //int sumevennum = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = rnumbers.Next(1, 99);
            //    Console.WriteLine(myArray[i]);
            //    sumevennum += myArray[i];
            //}


            //int minnumber = myArray[0];
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] < minnumber)
            //        minnumber = myArray[i];

            //}

            //int maxnumbers = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxnumbers)
            //        maxnumbers = myArray[i];
            //}

            //double average = sumevennum / (double)size;

            //Console.WriteLine($"\nМинимальное число: { minnumber}");
            //Console.WriteLine($"Максимальное число: {maxnumbers}");
            //Console.WriteLine($"Сумма всех элементов массива: {sumevennum}");
            //Console.WriteLine($"Среднее арифметическое всех чисел: {average}\n");
            //Console.WriteLine("Нечентные значения:");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] % 2 == 1)
            //        Console.WriteLine(myArray[i]);
            //}
            //Console.WriteLine("\n");



            //------------------------------------------------------------------------------------------



            //Задание 3,2


            //int arraylength = int.Parse(Console.ReadLine());
            //int[] myArray2 = new int[arraylength];
            //Random randomn = new Random();
            //Console.WriteLine("Вывод массива:");
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    myArray2[i] = randomn.Next(1, 99);
            //    Console.WriteLine(myArray2[i]);
            //}
            //Console.WriteLine("\nВывод массива в обратном порядке:");
            //for (int i = myArray2.Length -1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray2[i]);
            //}



            //-------------------------------------------------------------------------------------

            Console.WriteLine("\nВведите размер элементов массива:");
            int sizearray = int.Parse(Console.ReadLine());
            int[] myArray3 = new int[sizearray];
            Random rannumbers = new Random();
            Console.WriteLine("\nЭлементы массива:");
            for (int i = 0; i < myArray3.Length; i++)
            {
                myArray3[i] = rannumbers.Next(1, 99);
                Console.WriteLine($"{myArray3[i]} ");
            }
            Console.Write("Введите количесво элементов массива : ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите индекс:");
            int index = int.Parse(Console.ReadLine());

            int[] myArray4 = new int[count];
            

            for (int i = 0; i < count; i++)
            {
                if (index < myArray3.Length)
                    myArray4[i] = myArray3[index];
                else
                    myArray4[i] = 1;
                index++;
                Console.WriteLine(myArray4[i] + " ");
            }


        }
    }
}
