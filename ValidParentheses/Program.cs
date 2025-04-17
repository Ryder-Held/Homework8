// Creator: Ryder Held
// Date: 4/15/2025
namespace ValidParentheses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "{}[]()()";
            string newS = "";
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            bool result = false;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == '(' && s[j] == ')')
                    {
                        newS = s.Replace("(", "").Replace(")", "");
                        check1 = true;
                    }
                    if (s[i] == '(' && s[j] != ')')
                    {
                        check1 = false;
                    }
                }
            }
            for (int i = 0; i < newS.Length; i++)
            {
                for (int j = 0; j < newS.Length; j++)
                {
                    if (s[i] == '[' && s[j] == ']')
                    {
                        newS = newS.Replace("[", "").Replace("]", "");
                        check2 = true;
                    }
                    if (s[i] == '[' && s[j] != ']')
                    {
                        check2 = false;
                    }
                }
            }
            for (int i = 0; i < newS.Length; i++)
            {
                for (int j = 0; j < newS.Length; j++)
                {
                    if (s[i] == '{' && s[j] == '}')
                    {
                        newS = newS.Replace("{", "").Replace("}", "");
                        check3 = true;
                    }
                    if (s[i] == '{' && s[j] != '}')
                    {
                        check3 = false;
                    }
                }
            }
            if (check1 && check2 && check3 == true)
            {
                result = true;
            }
            Console.WriteLine(result);
        }
    }
}
