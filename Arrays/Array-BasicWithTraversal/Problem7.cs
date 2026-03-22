using System;
class Solution 
{
  public bool ArrayEqual(int[] array1,int[] array2)
  {
    bool Equal=array1.Length==array2.Length;
    for(int i=0;i<array1.Length && Equal;i++)
    {
      if(array1[i]==array2[i]) continue;
      else
      {
        return false;
      }
    }
    return Equal;
  }
}
class Program{
  static void Main(){
    int[] array1={3,4,5};
    int[] array2={3,4,5};
    var sln=new Solution();
    bool result=sln.ArrayEqual(array1,array2);
    Console.Write(result?"Equal":"Not equal");
  }
}
