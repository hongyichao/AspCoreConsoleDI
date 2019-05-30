using System;
using System.Collections.Generic;
using System.Text;
using Serilog;
namespace ClassLibrary1
{
    public class Class2 : Interface1
    {
        public void dosomething2()
        {

            Log.Information("test123");
        }
    }
}
