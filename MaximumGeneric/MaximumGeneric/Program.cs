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
                Console.WriteLine("Enter choice of program : \n1. Maximum integer \n2. Maximum Float \n3. Maximum String \n4. Exit");
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
                        String first = Convert.ToString(Console.ReadLine());
                        String second = Convert.ToString(Console.ReadLine());
                        String third = Convert.ToString(Console.ReadLine());
                        String result3 = Max.Computemaximum(first, second, third);
                        Console.WriteLine("The maximum number is : " + result3);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}