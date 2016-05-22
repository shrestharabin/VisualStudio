using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class BaseClass
    {
        public DateTime SysCreate { get; set; }
        public virtual void display()
        {
            Console.WriteLine("Base Class");
        }
    }

    public class DerivedOverwrite : BaseClass
    {
        public void display()
        {
            Console.WriteLine("Overwirte");
        }

    }

    public class DerivedOverride : BaseClass
    {
        public override void display()
        {
            Console.WriteLine("Override");
        }

    }
}
