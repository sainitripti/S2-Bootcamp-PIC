using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidatorLib
{
    public class DataValidator
    {
        public bool IsDataValueZero(int data)
        {
            if(data==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
