using System;
class Solution 
{
  public int[] RotateRight(int[] arr)
  {
    int last=arr[arr.Length-1];
    for(int i=arr.Length-1;i>0;i--)
    {
      arr[i]=arr[i-1];
    }
    arr[0]=last;
    return arr;
  }
  public int[] RotateLeft(int[] arr)
  {
    int first=arr[0];
    for(int i=0;i<arr.Length-1;i++){
      arr[i]=arr[i+1];
    }
    arr[arr.Length-1]=first;
    return arr;
  }
}
class Program{
  static void Main(){
    int[] arr = { 6,7,8,9 };
    var sln=new Solution();
    int[] result=sln.RotateRight(arr);
    foreach(int a in result) Console.Write(a+" ");
  }
}
