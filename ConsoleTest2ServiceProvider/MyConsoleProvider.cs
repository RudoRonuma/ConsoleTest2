using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest2ServiceProvider
{
    public class MyConsoleProvider
    {
        public static string GetProvidingString() =>
            typeof(MyConsoleProvider).Assembly.GetName().Version!.ToString();
    }
}
