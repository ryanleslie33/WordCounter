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
     string inputValue = userWord;

     Translate testTranslate = new Translate();
      Assert.AreEqual(inputValue, testWordCounter.FindWord(userWord));
   }
}
}
