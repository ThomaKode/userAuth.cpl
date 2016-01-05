using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userAuth.cpl.UITests
{
    /// <summary>
    /// A class used for concatenating names user-submitted forms.
    /// </summary>
    public class NameConcat
    {
        public static void Concat()
        {
            string str1 = "This is where we concatenate names";
            string str2 = "For example, (a).concat(b)=ab";
            string str3 = string.Concat(str1, str2);
            Console.WriteLine(str3);
            Console.ReadLine();
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
