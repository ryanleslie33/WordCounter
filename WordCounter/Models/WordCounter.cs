using System.Collections.Generic;


namespace WordCountName.Models
{
  public class WordCounter
  {
    private string _userWord;
    private string _userSentence;
    private int _id;


    private static List<WordCounter> _instances = new List<WordCounter> {};

    public WordCounter(string userWord, string userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public static int GetReturnCount(string userWord,string userSentence)
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
      public  int GetCount()
      {
        return WordCounter.GetReturnCount(_userWord,_userSentence);
      }

      // public static int   SetReturnCount()
      // {
      //   return result;
      // }
      public int GetId()
      {
        return _id;
      }
      public string GetWord()
      {
        return _userWord;
      }
      public void SetWord(string userWords)
      {
       _userWord = userWords;
      }
      public string GetSentence()
      {
        return _userSentence;
      }
      public void SetSentence(string userSentences)
      {
       _userSentence = userSentences;
      }
      public static List<WordCounter> GetAll()
      {
        return _instances;
      }
      public static WordCounter Find(int searchId)
      {
        return _instances[searchId-1];
      }
      public static void ClearAll()
      {
        _instances.Clear();
      }

    }
  }



// }
