using System;

//loops
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //input testscore
    //Syntax of the while loop while condition: while(condition){}

  int counter = 0;
  int total = 0;  

  while (counter < 8)
  {
    Console.WriteLine("Enter score of kid");
    int testscore = Convert.ToInt32(Console.ReadLine());
    total = total + testscore;
    counter++;//counter = counter + 1
  }
  
  double average = total / 8;

  Console.WriteLine("Average = " + average);


  }
}