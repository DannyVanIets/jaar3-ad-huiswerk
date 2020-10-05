using System;

namespace AD
{
    public static class BracketChecker
    {

        /// <summary>
        ///    Run over all characters in a string, push all '(' characters
        ///    found on a stack. When ')' is found, it shoud match a '(' on
        ///    the stack, which is then popped.
        ///
        ///    If ')' is found when no '(' is on the stack, this method will
        ///    terminate prematurely, no further inspection is needed.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>Returns True if all '(' are matched by ')'.
        /// Returns False otherwise.</returns>
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


        /// <summary>
        ///    Run over all characters in a string, when an opening bracket is
		///    found the closing counterpart from closeChar is pushed on a Stack
        ///    When an closing bracket is found, it should match the top character
		///    from this stack.
		///    
        ///    This method will terminate prematurely if a wrong or missmatched
        ///    closing bracket is found and no further inspection is needed.
		/// </summary>
		/// <param name="s">The string to check</param>
		/// <returns>Returns True if all opening brackets are matched by
		/// it's correct counterpart in a correct order.
        /// Returns False otherwise.</returns>
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
