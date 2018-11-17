using System;


namespace WordCountName
{

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("enter a word");
      string userWord = Console.ReadLine();
      // var array1 = userWord.ToCharArray();

      Console.WriteLine("enter a sentence");
      string userSentence = Console.ReadLine();

int Count = WordCounter.ReturnCount(userWord,userSentence);
Console.WriteLine(Count);
  }
  }
}
