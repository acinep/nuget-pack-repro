using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class ClassicClass
    {

        public string Foo()
        {
            var netStandardClass = new NetStandardLibrary.NetStandardClass();

            return netStandardClass.Foo;
        }
    }
}
