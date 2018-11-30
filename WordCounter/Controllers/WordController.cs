using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCountName.Models;

namespace WordCountName.Controllers
{
  public class WordController : Controller
  {
    [HttpGet("/WordCounterView")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/WordCounterView/New")]
      public ActionResult New()
      {
        return View();
      }
  //     [HttpPost("/WordCounterView")]
  // public ActionResult Create(string userWord, string userSentence)
  // {
  //   return RedirectToAction("Index" );
  // }
}
}
