using System;

public class UnitTest {

  public static void Test3Plus1()
  {
      Solution s = new Solution();
      string answer = s.AddBinary("11", "1");
      Assert(answer, "100", $"11 + 1 in binary is 100 or 4. You Provided {answer}");
  }
  
  public static void Test10Plus11()
  {
      Solution s = new Solution();
      string answer = s.AddBinary("1010", "1011");
      Assert(answer, "10101", $"1010 + 1011 in binary is 10101 or 21. You Provided {answer}");
  }
 
  public static void Assert(string value, string correctValue, string testcase) 
  {
      if (value == correctValue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }
}