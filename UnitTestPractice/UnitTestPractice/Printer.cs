using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPractice
{
    public class Printer
    {   
        private readonly IDependency _dependency;
        public Printer(IDependency dependency)
        { 
            _dependency = dependency;
        }

        public string Print()
        {
            _dependency.ImportantMethod();
            return "print completed";

        }
    }
}
