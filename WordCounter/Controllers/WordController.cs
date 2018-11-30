using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCountName.Models;

namespace WordCountName.Controllers
{
  public class WordController : Controller
  {
    [HttpGet("/Word")]
    public ActionResult Index()
    {

      List<WordCounter> allWordCounter = WordCounter.GetAll();
      return View(allWordCounter);
    }
    [HttpGet("/Word/New")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/Word")]
    public ActionResult Create(string userWord, string userSentence)
    {
      WordCounter myWord = new WordCounter(userWord, userSentence);
      return RedirectToAction("Index");
    }
    [HttpGet("/Word/{id}")]
    public ActionResult Show(int id)
    {
    WordCounter myWord = WordCounter.Find(id);
      return View(myWord);
    }

}
}
