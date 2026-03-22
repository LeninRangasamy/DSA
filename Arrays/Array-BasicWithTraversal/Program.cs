using System;
using System.Net;
namespace DSAconsole;
public class Solution
{
    public int ThirdLargest(int[] array)
    {
        int First=int.MinValue;
        int Second=int.MinValue;
        int Third=int.MinValue;
        foreach(int a in array)
        {
            if (a > First)
            {
                Third=Second;
                Second=First;
                First=a;
            }
            else if (a > Second)
            {
                Third=Second;
                Second=a;
            }
            else if (a > Third)
            {
                Third=a;
            }
        }
        return Third;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int[] array={5,7,1,67,23,96,12,30};
        var sln=new Solution();
        int result=sln.ThirdLargest(array);
        Console.Write(result);
    }
}
