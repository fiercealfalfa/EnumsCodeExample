using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    
    class SecondEnumExample
    {
        enum Notes { Ab, A, Bb, B, C, Db, D, Eb, E, F, Fb, G };
        public void showSecondEnumExample()
        {
            
            int superTonic = (int)Notes.A;
            Console.WriteLine("This is the value that is in superTonic: {0}", superTonic);
            string[] scale = Enum.GetNames(typeof(Notes));
            Console.WriteLine("This is the value in scale: {0}",  scale);
            int numNotes = scale.Length;
            Console.WriteLine("This is the value in numNote: {0}", numNotes);
            Console.WriteLine("This is the 5th element of Scale: {0}", scale[5]);
            Console.WriteLine("Below is a foreach loop that prints out the whole contents of scale");
            foreach (string note in scale)
            {

                Console.WriteLine(note);
            }
        }
    }
}
