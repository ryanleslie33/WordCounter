using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCountName.Models;

namespace WordCountName.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/Word")]
    public ActionResult Index()
    {
      
      return View(allCategories);
    }
    [HttpGet("/Word/new")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/word")]
  public ActionResult Create(string userWord, string userSentence)
  {

    return RedirectToAction("Index", );
  }
