A greedy algorithm is an algorithm that follows the principle of making the locally optimal choice at each stage with the hope of finding a global optimum. In other words, a greedy algorithm makes the best choice at the moment, without considering the long-term consequences of this choice.

One example of a greedy algorithm is the famous algorithm for finding the shortest path between two points on a map, called Dijkstra's algorithm. This algorithm works by starting at the starting point and then considering all of the possible paths that can be taken from that point. At each step, it chooses the path that leads to the next point that is closest to the destination, until the destination is reached.

In terms of when to use a greedy algorithm, it is best suited for situations where there are many options to choose from, but where the locally optimal choice is likely to lead to the global optimum. For example, the problem of finding the shortest path on a map is a good candidate for a greedy algorithm, because at each step, the locally optimal choice is to take the path that leads to the next point that is closest to the destination.

Here is an example of a greedy algorithm written in C# to solve the problem of finding the minimum number of coins needed to make a given amount of change:

```c#
// Function to find the minimum number of coins needed to make a given amount of change
int minCoins(int[] coins, int change)
{

    // Sort the coins in descending order
    Array.Sort(coins, (a, b) => b - a);

    // Keep track of the number of coins used
    int numCoins = 0;

    // Loop through the coins and add as many as needed to make the change
    for (int i = 0; i < coins.Length; i++)
    {
        while (change >= coins[i])
        {
            change -= coins[i];
            numCoins++;
        }
    }

    // Return the total number of coins used
    return numCoins;

}
```
This algorithm works by first sorting the coins in descending order so that the largest coins are considered first. It then loops through the coins and adds as many as needed to make the change, until the change is equal to zero. This approach is greedy, because at each step, the algorithm chooses the largest coin that is less than or equal to the remaining change, without considering the long-term consequences of this choice.

Overall, greedy algorithms can be a useful tool for solving optimization problems, but they are not always the best choice. In some cases, a different algorithm that takes into account the long-term consequences of its choices may be more effective at finding the global optimum.
