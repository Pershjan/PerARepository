using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!isValid(args))
            {
                ShowHelpText();
                return;
            }
            var length = Convert.ToInt32(args[1]);
            var options = args[1];
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;
            
            var lengthStr = args[0];
            var options = args[1];

            foreach (var character in options)
            {
                if (character != 'l'
                    && character != 'u'
                    && character != 's'
                    && character != 'd')
                {
                    return false;
                }
            }

            foreach (var character in lengthStr)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("PasswordGenerator <length> <options>");
            Console.WriteLine(" Options:");
            Console.WriteLine(" - u = upper case letter");
            Console.WriteLine(" - l = lower case letter");
            Console.WriteLine(" - d = digit");
            Console.WriteLine(" - s = special character (!\"#¤%&(){}[]");
            Console.WriteLine("Example: Passwordgenerator 14 lussdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }

    }
}
