using System;
class SelectionSort
{
    static void Main()
    {
        int[] arr={5,1,4,2,6,3};
        int n=arr.Length;
        
        for(int i=0;i<n-1;i++)
        {
            int MinIndex=i;
            for(int j=i+1;j<n;j++)
            {
                if(arr[MinIndex]>arr[j])
                {
                    MinIndex=j;
                }
            }
            int temp=arr[i];
            arr[i]=arr[MinIndex];
            arr[MinIndex]=temp;
        }
        Console.WriteLine("Sorted array");
        foreach(int a in arr) Console.Write(a+",");
    }
}
