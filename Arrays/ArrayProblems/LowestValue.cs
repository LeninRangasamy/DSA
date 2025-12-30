using System;
class Program{
  static void Main(){
    int[] arr={3,2,6,-3,9,1,5};
    int minVal=arr[0];
    int size=arr.Length;
    //Algorithm for finding lowest value
    for(int i=0;i<size-1;i++){
        if(arr[i]<minVal){
          minVal=arr[i];
          //It stores lowest value when the if condition becames true    
        }
    }
    Console.WriteLine($"Lowest value is {minVal}");
  }
}
