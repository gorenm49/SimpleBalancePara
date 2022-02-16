using System;

namespace SimpleBalancePara
{
    public class Balance
    {
        public StackClass stack= new StackClass();
        public string expression = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";

        public void BalanceCheck()
        {
            char[] arrayOfexpression = expression.ToCharArray();
            
            for (int i = 0; i < arrayOfexpression.Length; i++)
            {
                if (arrayOfexpression[i]=='(')
                {
                    stack.Push(arrayOfexpression[i]);
                }
                if (arrayOfexpression[i]==')')
                {
                    if (stack.top.Equals('('))
                    {
                        stack.Pop();
                    }
                }
            
            }

            if (stack.IsEmpty().Equals(0))
            {
                System.Console.WriteLine("Expression is Balanced");
            }
            else
            {
                System.Console.WriteLine("Expression is not balanced");
            }
        }
    }
}