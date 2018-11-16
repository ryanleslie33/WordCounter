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
     string userSentence = "bring it over bill";
  string Replace = userSentence.Replace(userWord,"");

     Translate testTranslate = new Translate(userWord,userSentence,Replace);
      Assert.AreEqual(Replace, testTranslate.FindWord(userWord,userSentence,Replace));
   }
}
}
