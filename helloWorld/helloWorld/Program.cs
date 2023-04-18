using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //calling helloWorld function

                HelloWorld();

            //int num1 = Convert.ToInt32(Console.ReadLine()); //taking integer input 
            // int num2 = Convert.ToInt32(Console.ReadLine());
           // int num2 = Int32.Parse(Console.ReadLine());//another method to take integer as input
            //add(num1, num2); //calling add function

            //int ans = ReverseNumber(123456789);
           // Console.WriteLine(ans);
           // anscii_value();
           // check_vowel();

            Right_angle_trangle_pattern(15);
            Mirror_Right_angle_trangle_pattern(15);
            trangle_pattern(15);
            V_trangle_pattern(15);
            Console.ReadLine();
        }

        //hello world function
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine(); // it will take a character as input
        }

        //add function
        static void add(int num1,int num2)
        {
            int result;
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        //reverse number function
        static int ReverseNumber(int num)
        {
            int rev = 0;
            while(num>0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            return rev;
        }

       
        //anscii value of any charcter

        static void anscii_value()
        {
            char ch =char.Parse(Console.ReadLine());
            int ancii_val = Convert.ToInt32(ch);
            Console.WriteLine(ancii_val);
        }

        //checking for vowel
        static void check_vowel()
        {
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='A' || ch=='a' || ch == 'E' || ch == 'e' || ch == 'I' || ch == 'i' || ch == 'O' || ch == 'o' || ch == 'U' || ch == 'u')
            {
                Console.Write("vowel");

            }
            else
            {
                Console.Write("Consonent");
            }
        }

        //star pattern programs

        static void Right_angle_trangle_pattern(int n)
        {
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void Mirror_Right_angle_trangle_pattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(j>=n+1-i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        static void trangle_pattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (2*n)-1; j++)
                {
                    if (j >= n + 1 - i && j<=n-1+i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        static void V_trangle_pattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (2 * n) - 1; j++)
                {
                    if (j <=i || j >= (2 * n) - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }



       
    }
}
