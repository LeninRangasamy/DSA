using System;
using System.Net;
using System.Collections.Generic;
namespace DSAconsole;
public class Solution
{
    public int RepeatingNumber(int[] array)
    {
        HashSet<int> set=new HashSet<int>();  //Creating new hashset 
        foreach(int a in array)
        {
            if (set.Contains(a)) //Checks if hashset contains following element
            {
                return a;
            }
            set.Add(a);  //Adding element in the hashset
        }
        return -1;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        int[] array={1,2,3,5,6,3,7,8};
        var sln=new Solution();
        int result=sln.RepeatingNumber(array);
        Console.Write(result);
    }
}
