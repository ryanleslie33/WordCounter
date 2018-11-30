using System;


namespace WordCountName.Models
{
public   class WordCounter
  {
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
  }//end WordCounter
}
}



// }
