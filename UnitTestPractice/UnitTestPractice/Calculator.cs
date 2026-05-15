using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPractice
{
    public class Calculator
    {
        private int currentValue;

        public Calculator(int initValue)
        {
            currentValue = initValue;
        }

        public Calculator()
        {
            currentValue = 0;
        }


        public int Sum(int? number)
        {
            if (number == null)
            {
                return currentValue;
            }
            currentValue +=  number.Value;
            return currentValue;
        }

        public int Rest(int? number)
        {
            if (number == null)
            {
                return currentValue;
            }
            currentValue -= number.Value;
            return currentValue;
        }
    }
}
