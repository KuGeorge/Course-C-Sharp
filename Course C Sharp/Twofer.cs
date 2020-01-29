using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_C_Sharp
{
    class Twofer
    {
        public static void Test()
        {
            Console.WriteLine(TwoFer("Pancho"));
            Console.WriteLine(TwoFer("Rodri"));
            Console.WriteLine(TwoFer("Vane"));
            Console.WriteLine(TwoFer(""));
            Console.WriteLine(TwoFer(null));
            Console.ReadLine();
        }

        public static string TwoFer(string who)
        {
            string result = "One for {0}, one for me.";
            if (string.IsNullOrEmpty(who))
                result = string.Format(result, "you");
            else
                result = string.Format(result, who);
            return result;

        }
    }
}
