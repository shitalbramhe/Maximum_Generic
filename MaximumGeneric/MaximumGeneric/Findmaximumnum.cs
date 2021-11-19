using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumGeneric
{
    public class Findmaximumnum
    {
        public int Computemax(int firstnumber, int secondnumber, int thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0)
            {
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0)
            {
                return secondnumber;
            }
            else
            {
                return thirdnumber;
            }
        }
        public float Computemax1(float firstnumber, float secondnumber, float thirdnumber)
        {
            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0)
            {
                return firstnumber;
            }
            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0)
            {
                return secondnumber;
            }
            else
            {
                return thirdnumber;
            }
        }
        public string Computemaximum(string firstword, string secondword, string thirdword)
        {
            if (firstword.CompareTo(secondword) > 0 && firstword.CompareTo(thirdword) > 0)
            {
                return firstword;
            }
            if (secondword.CompareTo(firstword) > 0 && secondword.CompareTo(thirdword) > 0)
            {
                return secondword;
            }
            else
            {
                return thirdword;
            }
        }

    }
}