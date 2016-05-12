using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class MyExtension
    {
        public static int Multiply(this int i)
        {
            return i * i;
        }
    }
}
