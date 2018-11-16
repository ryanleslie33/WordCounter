using System;


namespace WordCountName
{
public   class Translate
  {
  public string userWord;
  public string userSentence;
  public string Replace;

  public Translate(string inputValue, string userSentenceValue, string ReplaceValue)
{
      userWord = inputValue;
      userSentence = userSentenceValue;
      Replace = ReplaceValue;
}

    public string FindWord(string input,string userSentence, string ReplaceValue)
    {
      if ( userSentence.Contains(userWord))
      {
        return Replace;
      }
      else
      {
            return userSentence;
      }
    }
  }
}

     // var arr = userWord.ToCharArray();


//     }
//     public string RemoveWord()
//     {
// string userSentence = Consol.ReadLine();
// string[] split = userSentence.split(' ');
// for each()

//     }
//   }
// }
