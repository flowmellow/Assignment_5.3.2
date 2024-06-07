/*
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
Example 1:
Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps

Example 2:
Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.

1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
*/



namespace Assignment_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;               

            Console.WriteLine(Stairs(n));
        }

        public static int Stairs(int n)
        {
            int first = 1;
            int second = 2;
            

            if (n < 3)
            {
                return n;
            }
            else 
            {
                for (int i = 2; i < n; i++)
                {
                    int current = first + second;
                    first = second;
                    second = current;
                }
                return second;

            }
            
           
        }
    }
}
