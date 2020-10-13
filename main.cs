using System;

class MainClass {
  public static int IntegerPower(int ba , int ex){
    int answer = 1;
     for (int count = 0; count<ex; count++){
       answer = answer * ba; 
    }
    return answer;
  }
  
  public static void Main (string[] args) {
    Console.WriteLine ("IntegerPower(base, exponent)");
    Console.WriteLine("Please enter  base");
    int bas = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter exponent");
    int exp = Convert.ToInt32(Console.ReadLine());
    int ans = IntegerPower(bas , exp);
   
    Console.WriteLine("The answer is " + ans);
  }
}