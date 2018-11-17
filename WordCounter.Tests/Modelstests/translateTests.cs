using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCountName;

namespace WordCountName.Tests
{
  [TestClass]
  public class TranslateTests
  {

  [TestMethod]
   public void FindWord_Userinputwordisincludedinsentence_True()
   {
     string userWord = "bill";
     string userSentence = "bring it over bill bill";

     int Result = WordCounter.ReturnCount(userWord,userSentence);
      Assert.AreEqual(2,Result);
   }
   [TestMethod]
    public void FindWord_userEntersWordThatDoes_True()
    {
      string userWord = "bill";
      string userSentence = "bring it over bill bill";

      int Result = WordCounter.ReturnCount(userWord,userSentence);
       Assert.AreEqual(2,Result);
    }
}

}
