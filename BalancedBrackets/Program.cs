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
            string aString = "{{[]}}";
            Console.WriteLine(BalancedBrackets(aString));
            Console.ReadLine();
        }
        private static bool BalancedBrackets(string code)
        {
            int parens = 0;
            int bracks = 0;
            int curlies = 0;
            Stack<char> found = new Stack<char>();
            for (int i = 0; i < code.Length; i++){
                char thisOne = code[i];
                switch (thisOne)
                {
                    case '(':
                        parens++;
                        found.Push('(');
                        break;
                    case '[':
                        bracks++;
                        found.Push('[');
                        break;
                    case '{':
                        curlies++;
                        found.Push('{');
                        break;
                    case ')':
                        parens--;
                        char testParen = found.Pop();
                        if(parens < 0 || testParen != '(')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        bracks--;
                        char testBrack = found.Pop();
                        if (bracks < 0 || testBrack != '[')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        curlies--;
                        char testCurly = found.Pop();
                        if(curlies< 0 || testCurly != '{')
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }
            return found.Count == 0;
        }
    }
}
