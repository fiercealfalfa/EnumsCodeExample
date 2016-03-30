using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstEnumExample enum1 = new FirstEnumExample();

            //Console.WriteLine("Enum1 Example");
            //enum1.showExample();
            //Console.ReadKey();
            //SecondEnumExample enum2 = new SecondEnumExample();
            //Console.WriteLine("Enum2 Example");
            //enum2.showSecondEnumExample();
            //Console.ReadKey();
            Console.WriteLine("Enum Flag Examples are Below");
            EnumFlagExample enumflagexample = new EnumFlagExample();
            enumflagexample.showFlagExample();
            Console.ReadKey();
        }
    }
}
