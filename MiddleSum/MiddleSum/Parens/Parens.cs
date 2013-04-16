using System.Collections.Generic;

namespace CodingAgility.Parens
{
    public class Parens
    {
        public readonly string List;

        public Parens(string list)
        {
            List = list;
        }

        public int IsBalanced
        {
            get
            {
                if (string.IsNullOrEmpty(List))
                {
                    return 1;
                }

                Stack<char> stack = new Stack<char>();

                foreach (char c in List)
                {
                    if (c == '(')
                    {
                        // only action here is to push the parenthesis to the stack
                        stack.Push(c);
                    }
                    else if (c == ')')
                    {
                        // if we have ')' and an empty stack, easy indicator that our list is unbalanced
                        if (stack.Count == 0)
                        {
                            return 0;
                        }

                        // we only push '(' to the stack and the stack is non-empty, so pop it
                        stack.Pop();
                    }
                }

                // a balanced stack should have 0 items remaining once we have processed the list
                return stack.Count == 0 ? 1 : 0;
            }
        }
    }
}
