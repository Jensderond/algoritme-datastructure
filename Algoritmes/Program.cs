using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Xml.XPath;

namespace Algoritmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] list1 = new[] { 1, 2, 5, 23, 34 };
            int[] list2 = new[] { 2, 5, 6, 8, 12, 16, 22, 34, 42, 66, 78};

            //int[] mergeList = MergeSort(list1, list2);
            //CalculateOddMagicSquare();
/*            Console.WriteLine(list1);
            Console.WriteLine(list2);*/
            //Console.WriteLine(mergeList);
            //Console.WriteLine(BucketSort(list2).ToArray().ToString());
/*            Console.WriteLine("Forloop fibo");
            Console.WriteLine(ForFibo(5));
            Console.WriteLine("Recursive fibo");
            Console.WriteLine(Fibonacci(1,1,1,6));*/
            var s = "meetsysteem";
            Console.WriteLine(Palindroom(s));



            Console.ReadLine();
        }



        public static bool Palindroom(string p)
        {
            if (p.Length == 1 || p.Length == 0)  //added check for even cases
                return true;
            if (p[0] != p[p.Length - 1])
                return false;
            
            return Palindroom(p.Substring(1, p.Length - 2)); ;
            
        }

        public static decimal BinairyToDecimal(string binary, decimal resultDecimal)
        {
            if (num > 0)
            {
                BinairyToDecimal(num / lala, lala);
                System.out.print(num % lala);
            }

        }



















        public static List<int> BucketSort(int[] x)
        {
            List<int> result = new List<int>();

            //Determine how many buckets you want to create, in this case, the 10 buckets will each contain a range of 10
            //1-10, 11-20, 21-30, etc. since the passed array is between 1 and 99
            int numberOfBuckets = 10;

            //Create buckets
            List<int>[] buckets = new List<int>[numberOfBuckets];
            for (int i = 0; i < numberOfBuckets; i++)
                buckets[i] = new List<int>();

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucketOfChoice = (x[i] / numberOfBuckets);

                buckets[bucketOfChoice].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            //Each sublist is sorted using Bubblesort, but you could substitute any sorting algo you would like
            for (int i = 0; i < buckets.Length; i++)
            {
                int[] temp = BubbleSortList(buckets[i]);
                result.AddRange(temp);
            }

            return result;
        }

        //Bubblesort w/ ListInput
        public static int[] BubbleSortList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input.ToArray();
        }

        public static int[] MergeSort(int[] list1, int[] list2)
        {
            int[] merge = new int[list1.Length + list2.Length];

            int c1 = 0;
            int c2 = 0;

            for (int i = 0; i < merge.Length ; i++)
            {
                if (c1 == list1.Length && c2 != list2.Length)
                {
                    merge[i] = list2[c2];
                    c2++;
                }
                else if (c2 == list2.Length && c1 != list1.Length)
                {
                    merge[i] = list1[c1];
                    c1++;
                }
                else if (list1[c1] < list2[c2])
                {
                    merge[i] = list1[c1];
                    c1++;
                }
                else if (list1[c1] > list2[c2])
                {
                    merge[i] = list2[c2];
                    c2++;
                }
                else if (list1[c1] == list2[c2])
                {
                    merge[i] = list1[c1];
                    c1++;
                }
            }

            return merge;
        }

        public static int Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number)
            {
                Fibonacci(b, a + b, counter+1, number);
            }
            if (counter == number)
            {
                return b;
            }
            return 1;
        }

        public static int ForFibo(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static void CalculateOddMagicSquare()
        {
            var n = 5;
            int[,] matrix = new int[5,5];

            int nsqr = n * n;
            int i = 0, j = n / 2;     // start position

            for (int k=1; k<=nsqr; ++k) 
            {
                matrix[i,j] = k;

                i--;
                j++;

                if (k%n == 0) 
                { 
                    i += 2; 
                    --j; 
                }
                else 
                {
                    if (j == n)
                    {
                        j -= n;
                    }
                    else if (i < 0)
                    {
                        i += n;
                    }
                }
            }
        }
    }
}
