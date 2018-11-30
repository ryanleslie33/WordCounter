using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCountName;

namespace WordCountName.Tests
{
  [TestClass]
  public class WordCounterTests
  {

  [TestMethod]
   public void FindWord_Userinputwordisincludedinsentence_True()
   {
     string userWord = "bill";
     string userSentence = "bring it over bill ";
     // WordCounter newWordCounter = new WordCounter(userWord, userSentence);

     int Result = WordCounter.ReturnCount(userWord,userSentence);
      Assert.AreEqual(1,Result);
   }
   [TestMethod]
    public void FindWord_user_inputWord_is_included_in_the_sentence_twice_True()
    {
      string userWord = "bill";
      string userSentence = "bring it over bill bill";

      int Result = WordCounter.ReturnCount(userWord,userSentence);
       Assert.AreEqual(2,Result);
    }
    [TestMethod]
     public void FindWord_user_inputWord_is_counted_with_uppercasing_True()
     {
       string userWord = "Bill";
       string userSentence = "bring it over bill bill";

       int Result = WordCounter.ReturnCount(userWord,userSentence);
        Assert.AreEqual(2,Result);
     }
     [TestMethod]
      public void FindWord_user_inputWord_is_nothing__True()
      {
        string userWord = "";
        string userSentence = "";

        int Result = WordCounter.ReturnCount(userWord,userSentence);
         Assert.AreEqual(1,Result);
      }
 }
}
