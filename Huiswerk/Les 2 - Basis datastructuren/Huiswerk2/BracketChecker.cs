using System;

namespace AD
{
    public static class BracketChecker
    {
        public static bool CheckBrackets(string s)
        {
            IMyStack<string> stack = DSBuilder.CreateMyStack();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(s[i].ToString());
                }
                else if (s[i] == ')' && !stack.IsEmpty())
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (stack.IsEmpty())
            {
                return true;
            }
            return false;
        }

        public static bool CheckBrackets2(string s)
        {
            IMyStack<string> stack = DSBuilder.CreateMyStack();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i].ToString());
                }
                else if ((s[i] == ')' && stack.Top() == "(" || 
                    s[i] == ']' && stack.Top() == "[" || 
                    s[i] == '}' && stack.Top() == "{")
                    && !stack.IsEmpty())
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (stack.IsEmpty())
            {
                return true;
            }
            return false;
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
