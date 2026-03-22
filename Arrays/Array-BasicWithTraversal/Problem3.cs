using System;
using System.Net;
namespace DSAconsole;
public class Solution
{
    public bool SearchElement(int[] array,int target)
    {
        foreach(int a in array)
        {
            if(a==target) return true;
        }
        return false;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int[] array={5,7,1,67,23,96,12,30,3};
        var sln=new Solution();
        bool result=sln.SearchElement(array,3);
        Console.Write(result?"Target found":"Target not found");
    }
}
