using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCountName.Models;
using System.Collections.Generic;
using System;


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

     int Result = WordCounter.GetReturnCount(userWord,userSentence);
      Assert.AreEqual(1,Result);
   }
   [TestMethod]
    public void FindWord_user_inputWord_is_included_in_the_sentence_twice_True()
    {
      string userWord = "bill";
      string userSentence = "bring it over bill bill";

      int Result = WordCounter.GetReturnCount(userWord,userSentence);
       Assert.AreEqual(2,Result);
    }
    [TestMethod]
     public void FindWord_user_inputWord_is_counted_with_uppercasing_True()
     {
       string userWord = "Bill";
       string userSentence = "bring it over bill bill";

       int Result = WordCounter.GetReturnCount(userWord,userSentence);
        Assert.AreEqual(2,Result);
     }
     [TestMethod]
      public void FindWord_user_inputWord_is_nothing__True()
      {
        string userWord = "";
        string userSentence = "";

        int Result = WordCounter.GetReturnCount(userWord,userSentence);
         Assert.AreEqual(1,Result);
      }
      [TestMethod]
     public void GetId_WordsInstantiateWithAnIdAndGetterReturns_Int()
     {
      WordCounter.ClearAll();
       //Arrange
       string description = "Walk";
       string test = " this";
       WordCounter newWordCounter = new WordCounter(description, test );
       WordCounter newWordCounter2 = new WordCounter(description, test );

       //Act
       int result = newWordCounter2.GetId();

       //Assert why is this 3??????????????????????????????
       Assert.AreEqual(2, result);
     }
     [TestMethod]
      public void GetAll_ReturnsAllwordObjects_wordList()
      {
          WordCounter.ClearAll();
       //Arrange
       string name1 = "test";
       string name2 = "newtest";
       WordCounter newWordCounter1 = new WordCounter(name1,name2);
       WordCounter newWordCounter = new WordCounter(name1, name2 );
       List<WordCounter> newList = new List<WordCounter> { newWordCounter1, newWordCounter };
       //Act
       List<WordCounter> result = WordCounter.GetAll();
       Console.WriteLine("how many items"+ result.Count);
       //Assert
       CollectionAssert.AreEqual(newList, result);
      }
 }
}
