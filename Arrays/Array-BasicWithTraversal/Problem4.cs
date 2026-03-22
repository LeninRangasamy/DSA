using System;
using System.Net;
namespace DSAconsole;
public class Solution
{
    public int MissingNumber(int[] array)
    {
        int n=array.Length;
        int Expected=(n+1)*(n+2)/2;
        int Actual=array.Sum();
        return Expected-Actual;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int[] array={1,2,3,5,6,7,8};
        var sln=new Solution();
        int result=sln.MissingNumber(array);
        Console.Write(result);
    }
}
