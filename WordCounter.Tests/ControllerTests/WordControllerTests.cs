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
  public void Index_ReturnsCorrectView_True()
  {
    //Arrange
    WordController controller = new WordController();

    //Act
    ActionResult indexView = controller.Index();

    //Assert
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
  }
}
}
