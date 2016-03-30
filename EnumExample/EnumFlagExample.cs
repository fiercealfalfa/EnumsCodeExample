using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class EnumFlagExample { 
    [Flags]
    public enum DinnerItems
    {
        None = 0,
        Entree = 1,
        Appetizer = 2,
        Side = 4,
        Dessert = 8,
        Beverage = 16,
        BarBeverage = 32
    }


        public void showFlagExample() 
        {
            DinnerItems myOrder = DinnerItems.Appetizer | DinnerItems.Entree |
                                  DinnerItems.Beverage | DinnerItems.Dessert;
            DinnerItems flagValue = DinnerItems.Entree | DinnerItems.Beverage;
            Console.WriteLine("The Value of myOrder is: {0}", myOrder);
            Console.WriteLine("Thhe Value of flagValue is:{0}", flagValue);
            Console.WriteLine("{0} includes {1}: {2}", myOrder, flagValue, myOrder.HasFlag(flagValue));
            int myFlag = (int)flagValue;
            Console.WriteLine("This is an int of my Flag Value: {0}", myFlag);
            int myOrderFlags = (int)myOrder;
            Console.WriteLine("This is an int of my myOrder Value: {0}", myOrderFlags);


        }
    }
    
}
