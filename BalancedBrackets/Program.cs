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
            string aString = "[{{[]}}]";
            Console.WriteLine(BalancedBrackets(aString));
            Console.ReadLine();
        }
        private static bool BalancedBrackets(string code)
        {
            Stack<char> opens = new Stack<char>();
            for (int i = 0; i < code.Length; i++)
            {
                char thisOne = code[i];
                if (thisOne == '(' || thisOne == '[' || thisOne == '{')
                {
                    opens.Push(thisOne);
                }
                if (thisOne == ')' || thisOne == ']' || thisOne == '}')
                {
                    if (opens.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char testChar = opens.Pop();
                        switch (thisOne)
                        {
                            case ')':
                                if(testChar != '(')
                                {
                                    return false;
                                }
                                break;
                                ;
                            case ']':
                                if(testChar != '[')
                                {
                                    return false;
                                }
                                break;
                                ;
                            case '}':
                                if(testChar != '{')
                                {
                                    return false;
                                }
                                break;
                                ;
                        }
                    }
                }
            }
            return opens.Count == 0;
        }
    }
}
