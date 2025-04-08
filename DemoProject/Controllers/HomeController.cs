using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetQuestions()
        {
            var questions = new List<Question>
            {
                new Question { 
                    Id = 1
                    , QuestionText = "What is a scoped service?"
                    , Answer = "A service that can be used per request."
                    , Hint = "A helpful hint about scoped services."
                },
                new Question { 
                    Id = 2
                    , QuestionText = "What does MVC stand for?"
                    , Answer = "Model View Controller"
                    , Hint = "A helpful hint about MVC."
                }
            };
            return Ok(questions);
        }

    }
}
