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
            Stack<char> opens = new Stack<char>();
            for (int i = 0; i < code.Length; i++){
                switch (code[i])
                {
                    case '(':
                        opens.Push('(');
                        break;
                    case '[':
                        opens.Push('[');
                        break;
                    case '{':
                        opens.Push('{');
                        break;
                    case ')':
                        if (opens.Count == 0)
                        {
                            return false;
                        }
                        char testParen = opens.Pop();
                        if(testParen != '(')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if(opens.Count == 0)
                        {
                            return false;
                        }
                        char testBrack = opens.Pop();
                        if (testBrack != '[')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (opens.Count == 0)
                        {
                            return false;
                        }
                        char testCurly = opens.Pop();
                        if(testCurly != '{')
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }
            return opens.Count == 0;
        }
    }
}
