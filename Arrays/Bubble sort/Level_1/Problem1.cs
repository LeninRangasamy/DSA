using System;
class BubbleSort{
  static void Main(){
    int[] arr={1,5,4,7,2,9,3};
    int size=arr.Length;
    int SwapCount=0;
    
    //Bubble sort Algorithm
    
    //Outer loop for executing loop condition
    for(int i=0;i<size-1;i++){
      
      //Inner loop for sorting Algorithm
      for(int j=0;j<size-i-1;j++){
        
        //if condition for comparing first two elements in the array
        if(arr[j]>arr[j+1]){
          //swapping two elements
          int temp=arr[j];
          arr[j]=arr[j+1];
          arr[j+1]=temp;
          SwapCount++;  //Counting swaps
        }
      }
    }
    
    Console.WriteLine("Sorted array");
    
    foreach(var a in arr) Console.Write(a+",");
    Console.WriteLine($"\nTotal swap count {SwapCount}");
  }
}

