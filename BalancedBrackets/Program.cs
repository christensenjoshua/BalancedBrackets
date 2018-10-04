using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string aString = "{{}}";
            Console.WriteLine(BalancedBrackets(aString));
            Console.ReadLine();
        }
        private static bool BalancedBrackets(string code)
        {
            int parens = 0;
            int bracks = 0;
            int curlies = 0;
            for (int i = 0; i < code.Length; i++){
                switch (code[i])
                {
                    case '(':
                        parens++;
                        break;
                    case '[':
                        bracks++;

                        break;
                    case '{':
                        curlies++;
                        break;
                    case ')':
                        parens--;
                        if(parens < 0)
                        {
                            return false;
                        }
                        break;
                    case ']':
                        bracks--;
                        if(bracks < 0)
                        {
                            return false;
                        }
                        break;
                    case '}':
                        curlies--;
                        if(curlies< 0)
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }
            if(parens != 0 ||bracks != 0 || curlies != 0)
            {
                return false;
            }
            return true;
        }
    }
}
