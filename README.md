# Leetcode-algorithm

学习数据结构的最佳方法之一是按照学习计划来安排学习内容，并结合实际操作来巩固所学知识。首先，需要了解数据结构的基本概念和分类，包括线性结构、树形结构和图形结构等。其次，要深入学习各种数据结构的特点、适用场景和实现方法，如链表、数组、栈、队列、哈希表、二叉树、堆、图等。最后，要实践并练习使用这些数据结构，并不断思考和改进自己的学习方法。

With c#，only send me code with no comments.you shou refer to knapsack problem solution.My problem:Gennady is the best in competitive programming. He can solve any problem, so he has never lost a contest.But Gennady can’t abandon solving problems because it is unsportsmanlike behavior. So he has decided
to just choose a bad strategy that minimizes his total points for the contest.
There are n types of problems in the contest numbered from 1 to n. The number of tasks for each type of task is infinite. If a contestant solves problem `i` , he gets `pi` points. Gennady has read all problems and came up with a solution for each one. He knows that for the problem `i` he needs exactly `ti` minutes to write a solution. The final thing to do is to choose the order to write the solutions for the problems. Gennady noticed that he had T minutes remaining until the end of the contest.
Examination room rules: when answering questions, you cannot change the questions. When the test is over, the examinee will continue to answer the current questions. When the questions are completed, the test is over. When the time is up to t, if the examinee has just finished the exam, the exam will stop.

Now Gennady wants to choose the order of solving problems that minimizes his score for the contest.
Help him to find out the smallest number of points that he can get following the rules above. When the T time comes, if the examinee has just finished the exam, the exam will stop.
Input
Example Input:44, [1, 3, 8, 15,25], [120, 300, 600, 950,1500]. They respectively represent the test time t, the time required for each type of test questions, and the points obtained for each type of test questions.

Output
Example:2850.Gennady do fourth problems three times, and get 3*950=2850.


#include <ctime>
#include <cmath>
#include <cstdio>
#include <string>
#include <cstring>
#include <cstdlib>
#include <iostream>
#include <algorithm>//头文件准备
using namespace std;
const int INF=1e9;
int c[105],w[105],f[55005],n,v,ans=INF;
int main(){
    for (int i=1;i<=55000;i++){//初始化，也可以直接写在全局变量里：f[55005]={INF};
        f[i]=INF;
    }
    scanf ("%d %d",&n,&v);
    for (int i=1;i<=n;i++){
        cin>>c[i]>>w[i];//注意：在这题里，干草的价值是重量，所需的英镑才是价值
    }
    for (int i=1;i<=n;i++){
        for (int j=c[i];j<=v+5000;j++){
            f[j]=min(f[j],f[j-c[i]]+w[i]);//动态转移方程
        }
    }
    for (int i=v;i<=v+5000;i++){
        ans=min(ans,f[i]);//穷举最小值，一定要从v开始穷举！
    }
    printf ("%d\n",ans);
    while (1);//反抄袭
    return 0;
}

public static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
{
	int[,] K = new int[itemsCount + 1, capacity + 1];

	for (int i = 0; i <= itemsCount; ++i)
	{
		for (int w = 0; w <= capacity; ++w)
		{
			if (i == 0 || w == 0)
				K[i, w] = 0;
			else if (weight[i - 1] <= w)
				K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
			else
				K[i, w] = K[i - 1, w];
		}
	}

	return K[itemsCount, capacity];
}