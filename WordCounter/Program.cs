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
        // var array = userWord.ToCharArray();
      // string[] userSentence = userFirstSentence.split(' ');

        string Replace = userSentence.Replace(userWord,"");
        // string result = string.Join("", replace);

      Translate inputWord = new Translate(userWord,userSentence,Replace);
      string returnedString = inputWord.FindWord(userWord,userSentence,Replace);
      Console.WriteLine(returnedString);
    }
  }
}
