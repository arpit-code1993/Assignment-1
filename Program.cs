using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n3 = 5;
            printTriangle(n3);

            int n2 = 5;
            printSeries(n2);


            int[] Jewel = new int[] {1,3};
            int[] Stone = new int[] {1,3,3,3,3,4,5,6};
            int r4 = numJewelsInStones(Jewel, Stone);
            Console.WriteLine(r4);

            int[] a1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] a2 = new int[] { 1, 2, 3, 4, 5 };

            
            int[] r5 = getLargestCommonSubArray(a1, a2);
            for (int i = 0; i < r5.Length; i++)
            {
                Console.Write(r5[i] + " ,");
            }
            

           // solvePuzzle();*/
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                
                var checkdiv = new List<int>(); // List is used to accessed items by index, also size of list grows dynamically
                int i=x;
                while (i <= y)
                {
                    if (IsSelfDividingNumber(i))
                    {
                        checkdiv.Add(i);

                    }
                    i++;
                }
                    int j = 0;
                    while (j < checkdiv.Count)
                    {
                        Console.WriteLine(checkdiv[j]);
                        j++;    
                    }
                    
                  bool IsSelfDividingNumber(int n) // fucntion to calculate order  of numbers
                    {
                        int temp = n;
                        while (temp > 0)
                        {
                            int r = temp % 10;
                            if (r == 0 || n % r != 0)
                            return false;
                            temp /= 10;
                        }

                        return true;
                    }

                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }



        public static void printSeries(int n)
        {
            try
            {   
                int i,j,x;
                i = 0;j = 1;
                while (i<n)
                {
                    x = 1;
                    while (i<n&&x<=j)
                    {
                        Console.Write(j);
                        i++;x++;
                    }
                    j++;
                }
               }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                
                if (n < 0)
                    return;
                int x,y,z;
                x = n;
                while (x >= 1)
                {
                    y = n;
                    while (y>x)
                    {
                        Console.Write(" ");
                        y--;
                    }
                    z = 1;
                    while (z < 2 * x)
                    {
                        Console.Write("*");
                        z++;
                    }
                    Console.WriteLine();
                    x--;
                }
                
            }
            catch
            {
                
               Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
               int count = 0;
               
               for (int i = 0; i < J.Length; i++)
               {
                   for (int j=0;j<S.Length;j++)
                   {
                       if (J[i]==S[j])
                       {
                           count++;
                           
                       }
                   }
               }
               return count;
           }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {

                int s1  = 0, l1 = 0, s2 = 0, l2 = 0, i = 0, j = 0;
                do
                {
                    if (a[i] == b[j])  
                    {
                        if (l2 == 0)
                            s2 = i;
                        l2++;
                        i++;
                        j++;
                    }
                    else
                    {
                        if (l2 >= l1 && s1 <= s2)
                        {
                            l1 = l2;
                            s1 = s2;
                        }
                        l2 = 0;
                        if (a[i] > b[j])
                            j++;
                        else
                            i++;
                    }
                    if (i >= a.Length || j >= b.Length)
                        break;
                } while (true);
                if (l2 >= l1 && s1 <= s2)
                {
                    l1 = l2;
                    s1 = s2;
                }
                if (l1 > 0)
                {
                    int[] lcsa = new int[l1];
                    for (i = 0; i < l1; i++)
                    {
                        lcsa[i] = a[s1 + i];
                    }
                    return lcsa;
                    
                }
             }
                catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; 
        }


    }
}
