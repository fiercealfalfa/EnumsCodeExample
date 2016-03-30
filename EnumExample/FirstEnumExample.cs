using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class FirstEnumExample
    {
        enum Days { Sun, Mon = 5, tue, Wed, thu, Fri, Sat };

        public void showExample()
        {
            
            int WeekdayStart = (int)Days.Sun;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.WriteLine(Days.Sun);
            Console.ReadKey();

        }
    }
}
