```c#
using System; 

namespace MyProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] weight = { 1, 3, 4 };
            int[] value = { 15, 20, 30 };
            int bagsize = 4;
            Test01bag(bagsize, weight, value);
        }

        public static void Test01bag(int bagsize, int[] weight, int[] value)
        {

            int[] dp = new int[bagsize + 1];
            dp[0] = 0;
            for (int i = 0; i < weight.Length; i++)
            {

                for (int j = bagsize; j >= weight[i]; j--)
                {
                    dp[j] = Math.Max(dp[j], dp[j - weight[i]] + value[i]);

                }

                for (int j = 0; j <= bagsize; j++)
                {
                    Console.Write(dp[j] + " ");
                    if (j == bagsize)
                    {
                        Console.WriteLine(" ");
                    }

                }

            }
            //打印dp数组

        }
    }

}
```
