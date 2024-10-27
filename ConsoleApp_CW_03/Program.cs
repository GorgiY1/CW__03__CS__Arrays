using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CW_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrInt; 

            //arrInt = new int[20];

            //const int size = 6;
            //arrInt = new int[size];

            //const int row = 4;
            //int [] rr = new int[row] { 78, 9, 956, 79 };

            //int[] srr = new int[] { 78, 9, 956, 79,6,46};


            //int[] arr = new int[6] { 78, 9, 956, 79, 63, 6};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("{0} ",arr[i]);
            //}

            Random random = new Random();
            //int[] arr = new int[6] { 78, 9, 956, 79, 63, 6 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //arr[i] = random.Next();
            //    //arr[i] = random.Next(-12,12);
            //    arr[i] = random.Next(12*12);
            //}

            //foreach(int item in arr)
            //{
            //    Console.WriteLine("{0} ", item);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //     Console.WriteLine("{0} ",arr[i]);
            //}

            //double[] darr = new double[6];

            //for (int i = 0; i < darr.Length; i++)
            //{
            //    darr.SetValue(random.NextDouble() + random.Next(5,12), i);
            //}

            //foreach (double item in darr)
            //{
            //    Console.WriteLine("{0:F3} ", item);
            //}
            //int row = 3, col = 4;
            //int[,] arrChar = new int[,]{ { 1,2,3,4}, {9,8,7,4 }, {5,6,9,8} };

            //for (int i = 0; i < arrChar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrChar.GetLength(1); j++)
            //    {
            //        Console.Write("{0}\t", arrChar[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //int row = 3, col = 4;
            //char[,] arrChar = new char[row, col];

            //int row = 3, col = 4;
            //int[,,] arrChar = new int[3,2,4] 
            //{ 
            //    { {5, 6, 9, 8},{ 5, 6, 9, 8} },
            //    { {6, 5, 4, 4},{ 58, 64, 91, 81} },
            //    { {58, 95, 85, 45},{ 58, 68, 92, 88} }
            //};

            //for (int i = 0; i < arrChar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrChar.GetLength(1); j++)
            //    {
            //        for (int l = 0; l < arrChar.GetLength(2); l++)
            //        {
            //            Console.Write("{0}\t", arrChar[i, j,l]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            // Array[] tt = new Array[10];

            ///////////////////////////////////////////////////////////
            
            /*Написать программу, которая находит в массиве значения, 
             * повторяющиеся два и более раз, 
             * и показывает их на экран без дублирования.*/
            int[] arr = new int[20];
            int tmp = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,10);
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j] && arr[i] != tmp)
                    {
                        Console.Write("{0} ", arr[i]);
                        tmp = arr[i];
                        break;
                    }
                }
            }
               //arr.SetValue(random.NextDouble() + random.Next(5, 12), i);

            Console.WriteLine();

            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }

            ////////////////////////////////////////////////
            //double[][] arr = new double[random.Next(4, 8)][];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new double[random.Next(5, 10)];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = random.NextDouble() + random.Next(10, 20);
            //        // Array.Sort(arr[i]);
            //        Console.Write("{0:F3}\t", arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            //Array.Resize(ref arr[2], 9);

            /////////////////////////////////////////////////

            //int[] arr = { 34, 23, 12, 67 };

            //Array.Resize(ref arr, arr.Length + 1);

            //arr[arr.Length - 1] = 234;

            //foreach (int item in arr)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.WriteLine();

            ////////////////////////////////////////////////////////
            
            //int index = Array.IndexOf(arr, 37);
            //if (index >= 0)
            //{
            //    Console.WriteLine("{0} -> {1}", arr[index]);
            //}
            //else
            //{
            //    Console.WriteLine("{0} -> {1}", index);
            //}
        
            
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
