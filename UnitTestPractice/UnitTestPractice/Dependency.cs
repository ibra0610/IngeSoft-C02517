using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPractice
{
    public interface IDependency
    {
        void ImportantMethod();
    }

    public class Dependency : IDependency
    {
        public void ImportantMethod()
        {

        }

    }
}
