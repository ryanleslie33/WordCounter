using System;


namespace WordCountName
{

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("enter a word");
      string userWord = Console.ReadLine();

      Console.WriteLine("enter a sentence");
      string userSentence = Console.ReadLine();

        string Replace = userSentence.Replace(userWord,"");

      Translate inputWord = new Translate(userWord,userSentence,Replace);
      string returnedString = inputWord.FindWord(userWord,userSentence,Replace);
      Console.WriteLine(returnedString);
    }
  }
}
