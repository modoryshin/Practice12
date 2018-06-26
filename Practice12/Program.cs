using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Practice12
{
    class Program
    {
        static int EnterSize()
        {
            int s = 0;
            bool ok;
            do {
                Console.WriteLine("Enter the number of elements in array."+"\n");
                ok = Int32.TryParse(Console.ReadLine(), out s);
                if (!ok)
                    Console.WriteLine("Invalid data type." + "\n");
                else if (s <= 0)
                    Console.WriteLine("Inappropriate array size." + "\n");
            } while (!ok||s<=0);
            return s;
        }
        static int Inputs(int[] arr)
        {
            int swaps = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                    swaps++;
                }
            }
           foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            return swaps;
        }
        static int Sort(int[] arr)
        {
            int swaps = 0;
            int b = 0;
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                for(int i = left; i < right; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        b = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = b;
                        swaps+=1;
                    }
                }
                right--;
                for(int i = right; i > left; i--)
                {
                    if (arr[i - 1] < arr[i])
                    {
                        b = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = b;
                        swaps+=1;
                    }
                }
                left++;
            }
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            return swaps;
        }
        static void Print(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[,] jagged = new int[2,3];
            int size = EnterSize();
            int[] mas1 = new int[size];
         int[] mas2 = new int[size];
            int[] mas3 = new int[size];
            Random rnd = new Random();
            int n = rnd.Next(0,100);
            for(int i = 0; i < size; i++)
            {
                mas1[i] = n++;
            }
            n = rnd.Next(0, 100);
            for (int i = 0; i < size; i++)
            {
                mas2[i] = n--;
            }
            for (int i = 0; i < size; i++)
            {
                mas3[i] = rnd.Next(0, 100);
            }
            Print(mas1);
            Print(mas2);
            Print(mas3);
            Console.WriteLine("\n" + "With the method of simple inserts:");
            Console.WriteLine("New form of array:");
            int s1 = Inputs(mas1);
            jagged[0,0] = s1;
            Console.WriteLine("Number of swaps:"+"\n"+s1+"\n");
            Console.WriteLine("New form of array:");
            s1 = Inputs(mas2);
            jagged[0,1] = s1;
            Console.WriteLine("Number of swaps:" + "\n" + s1 + "\n");
            Console.WriteLine("New form of array:");
            s1 = Inputs(mas3);
            jagged[0,2] = s1;
            Console.WriteLine("Number of swaps:" + "\n" + s1 + "\n");
            Console.WriteLine("The collating sort:");
            Console.WriteLine("New form of array:");
            s1 = Sort(mas1);
            jagged[1, 0] = s1;
            Console.WriteLine("Number of swaps:" + "\n" + s1 + "\n");
            Console.WriteLine("New form of array:");
            s1 = Sort(mas2);
            jagged[1, 1] = s1;
            Console.WriteLine("Number of swaps:" + "\n" + s1 + "\n");
            Console.WriteLine("New form of array:");
            s1 = Sort(mas3);
            jagged[1, 2] = s1;
            Console.WriteLine("Number of swaps:" + "\n" + s1 + "\n");
            Console.WriteLine("Final comparison:");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Method number {0}", i + 1);
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(jagged[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
