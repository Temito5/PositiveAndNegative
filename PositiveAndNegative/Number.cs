using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveAndNegative
{
    public class Number
    {
		public bool IsPositive(int num)
        {
            if (num > 0)
            {
                return true;
            }
            if (num<0)
            {
                return false;
            }
            else
            {
                throw new ArgumentException("0!");   
            }
        }


	}
}
