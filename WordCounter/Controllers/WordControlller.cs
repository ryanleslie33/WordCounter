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
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }
    [HttpGet("/Word/new")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/word")]
  public ActionResult Create(string categoryName)
  {
    Category newCategory = new Category(categoryName);
    List<Category> allCategories = Category.GetAll();
    return RedirectToAction("Index", allCategories);
  }
