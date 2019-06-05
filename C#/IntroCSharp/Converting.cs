using System;

namespace IntroCSharp
{
    class Converting
    {
        static void Something()
        {
			//to string 
			//anta variabel x - uannsett datatype (av våre utvalgte)
            var x = true;
            string s = "" + x;
            double d = 99.123;
            string s2 = d.ToString("F");

			//to int 
            int i = Convert.ToInt32(d);

            float f = Convert.toSingle(i);
            float f2 = Convert.toSingle(d);

            double d2 = Convert.toDouble(s2);

        }

    }

}