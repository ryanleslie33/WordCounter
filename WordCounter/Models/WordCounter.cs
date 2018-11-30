using System;


namespace WordCountName.Models
{
  public class WordCounter
  {
    private string _userWord;
    private string _userSentence;
    private int _id;

    private static List<WordCounter> _instances = new List<WordCounter> {};

    public WordCounter(userWord, userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public static int ReturnCount(string userWord,string userSentence)
    {
      string[] words = userSentence.ToLower().Split(",.?/ ".ToCharArray() );
      int result = 0;
      foreach(string word in words)
      {
        if ( userWord.ToLower() == word)
        {
          result ++;
        }
      }
      // end foreach
      return  result;
      //end ReturnCount
      }
      public int GetId()
      {
        return _id;
      }
      public static List<City> GetAll()
      {
        return _instances;
      }
      public static City Find(int searchId)
      {
        return _instances[searchId-1];
      }
    }
  }



// }
