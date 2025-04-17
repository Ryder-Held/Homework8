// Creator: Ryder Held
// Date: 4/16/2025
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumberOfStudentsUnableToEatLunch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] students = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches = { 1, 0, 0, 0, 1, 1 };

            // Flips the array around so that the pushing of a stack gets it right
            sandwiches = sandwiches.Reverse().ToArray();

            Queue<int> studentsQueue = new Queue<int>();
            Stack<int> sandwichesStack = new Stack<int>();

            for (int i = 0; i < students.Length; i++)
            {
                studentsQueue.Enqueue(students[i]);
                sandwichesStack.Push(sandwiches[i]);
            }

            // Used to break the loop if no changes are detected
            int number = 0;
            int previous = 0;
            int unchanged = 0;
            int threshold = 10;

            while (sandwichesStack.Count() > 0)
            {
                int x = studentsQueue.Dequeue();
                int y = sandwichesStack.Pop();
                if (x != y)
                {
                    studentsQueue.Enqueue(x);
                    sandwichesStack.Push(y);
                }
                else
                {

                }

                if (number == previous)
                {
                    unchanged += 1;
                }
                else
                {
                    unchanged = 0;
                }

                if (unchanged >= threshold)
                {
                    break;
                }
            }
            int hungryStudents = studentsQueue.Count();
            Console.WriteLine(hungryStudents);
        }
    }
}
