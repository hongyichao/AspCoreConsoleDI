using System;
using Serilog;

namespace ClassLibrary1
{
    public class Class1: IClass1
    {
        Interface1 _test1;

        public Class1(Interface1 test1)
        {
            _test1 = test1;
        }

        public void WriteSomething() {

            Log.Information("Hello again and again, Serilog!");

            _test1.dosomething2();
        }

    }
}
