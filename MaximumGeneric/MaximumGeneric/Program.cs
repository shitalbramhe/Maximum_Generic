using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            Findmaximumnum Max = new Findmaximumnum();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Generic maximum problems");
                Console.WriteLine("Enter choice of program : \n1. Maximum integer \n2. Maximum Float \n3. Maximum String \n4. Refactor using Generic \n5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter first number, second number,third number");
                        int firstnumber = Convert.ToInt32(Console.ReadLine());
                        int secondnumber = Convert.ToInt32(Console.ReadLine());
                        int thirdnumber = Convert.ToInt32(Console.ReadLine());
                        int result = Max.Computemax(firstnumber, secondnumber, thirdnumber);
                        Console.WriteLine("The maximum number is : " + result);
                        break;
                    case 2:
                        Console.WriteLine("Enter first number, second number,third number");
                        float firstnum = float.Parse(Console.ReadLine());
                        float secondnum = float.Parse(Console.ReadLine());
                        float thirdnum = float.Parse(Console.ReadLine());
                        float result2 = Max.Computemax1(firstnum, secondnum, thirdnum);
                        Console.WriteLine("The maximum number is : " + result2);
                        break;
                    case 3:
                        Console.WriteLine("Enter first word, second word,third word");
                        string first = Convert.ToString(Console.ReadLine());
                        string second = Convert.ToString(Console.ReadLine());
                        string third = Convert.ToString(Console.ReadLine());
                        string result3 = Max.Computemaximum(first, second, third);
                        Console.WriteLine("The maximum number is : " + result3);
                        break;
                    case 4:
                        string result4 = FindmaxGeneric<int>.Computemaxgeneric<int>(10,20,30);
                        Console.WriteLine("The maximum number is : " + result4);
                        string result5 = FindmaxGeneric<float>.Computemaxgeneric<float>(10.8f, 20.6f, 30.9f);
                        Console.WriteLine("The maximum number is : " + result5);
                        string result6 = FindmaxGeneric<string>.Computemaxgeneric<string>("sanket","shital","prajakta");
                        Console.WriteLine("The maximum number is : " + result6);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}