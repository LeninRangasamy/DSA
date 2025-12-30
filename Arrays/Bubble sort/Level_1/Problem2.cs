using System;
class BubbleSort{
  public static void Main(string[] args)
  {
    int[] arr={1,2,3,5,4};
    int size =arr.Length-1;
    //Outert loop for number of passes
    for(int i=0;i<size;i++){
      bool swapped=false;  //This value is re-setted when loop runs that next iteration
      for(int j=0;j<size-i;j++){
        if(arr[j]>arr[j+1]){
          //Swap elements when 'if' condition true'
          int temp=arr[j];
          arr[j]=arr[j+1];
          arr[j+1]=temp;
          swapped=true; //Updating the variable to break initial sorts
        }
      }
     
      if(!swapped){
        Console.WriteLine($"No swaps in the pass of {i}. Array sorted");
        break;
      }
      
    }
    
    Console.WriteLine("Sorted array");
    foreach(var a in arr) Console.Write(a+",");
  }
}
