using System;
class BubbleSort{
  public static void Main(string[] args)
  {
    int[] arr={4,1,5,2,3};
    int n =arr.Length;
    //Outer loop for number of passes
    for(int i=0;i<n-1;i++){
      bool swapped=false;  //This value is re-setted when loop runs that next iteration
      for(int j=0;j<n-i-1;j++){
        if(arr[j]>arr[j+1]){
          //Swap elements when 'if' condition true'
          int temp=arr[j];
          arr[j]=arr[j+1];
          arr[j+1]=temp;
          swapped=true; //Updating the variable to break initial sorts
        }
      }
  
      if(!swapped){
        Console.WriteLine($"\nNo swaps in this pass. Array sorted");
        break;
      }
      
    }
    
    Console.WriteLine("Sorted array");
    foreach(var a in arr) Console.Write(a+",");
  }
}
