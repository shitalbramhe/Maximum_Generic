using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumGeneric
{
    public class FindmaxGeneric<T>
    {
        public static string Computemaxgeneric<T>(T firstvalue, T secondvalue, T thirdvalue) where T : IComparable<T>
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue.ToString(); 
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue.ToString();
            }
            else
            {
                return thirdvalue.ToString();
            }
        }
    }
}
