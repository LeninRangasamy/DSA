using System;
class Problem{
  public bool EvenOROdd(int n)=>(n%2==0?true:false);
}

class Program{
  public static void Main(string[] a){
    var p= new Problem();
    bool IsTrue=p.EvenOROdd(4);
    Console.Write(IsTrue?true: false);
  }
}
