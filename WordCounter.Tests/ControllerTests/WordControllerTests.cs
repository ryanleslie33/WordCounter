using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCountName.Controllers;
using WordCountName.Models;

namespace WordCountName.Tests
{
  [TestClass]
  public class WordControllerTest
  {
    [TestMethod]
    public void Index_HasCorrectModelType_WordCounterList()
    {
      //Arrange
      ViewResult indexView = new WordController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<WordCounter>));
    }

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      WordController controller = new WordController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      WordController controller = new WordController();

      //Act
      IActionResult view = controller.Create("Walk the dog", " walk the cat");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      WordController controller = new WordController();
      RedirectToActionResult actionResult = controller.Create("Walk the dog", "walk the cat") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
