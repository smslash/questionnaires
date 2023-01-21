using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EXAM.Abstract;
using EXAM.Models;
using EXAM.Implementation;

namespace EXAM.Controllers
{
    public class TestController : Controller
    { private IAnswers db;
    public TestController() {
      db = new AnswerAdoNetService();
    }
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

    public ActionResult Create() {
      return View();
    }

    // POST: My/Create
    [HttpPost]
    public ActionResult Create(Answers answer) {
      try {
        // TODO: Add insert logic here
        db.Create(answer);
        return RedirectToAction("Index");
      } catch {
        return View();
      }
    }
  }
}