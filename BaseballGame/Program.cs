// Creator: Ryder Held
// Date: 4/16/2025
using System;

namespace BaseballGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string operations = "52CD+";
            List<string> record = new List<string>();
            int score = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == '+')
                {
                    int num1 = int.Parse(record[record.Count - 1]);
                    int num2 = int.Parse(record[record.Count - 2]);
                    int num3 = num1 + num2;
                    string completed = num3.ToString();
                    record.Add(completed);
                }

                else if (operations[i] == 'C')
                {
                    record.Remove(record[i - 1]);
                }

                else if (operations[i] == 'D')
                {
                    int convert = int.Parse(record[record.Count - 1]);
                    convert *= 2;
                    string converted = convert.ToString();
                    record.Add(converted);
                }

                else
                {
                    record.Add(operations[i].ToString());
                }
            }

            for (int i = 0; i < record.Count; i++)
            {
                score += int.Parse(record[i]);
            }
            Console.WriteLine(score);
        }
    }
}