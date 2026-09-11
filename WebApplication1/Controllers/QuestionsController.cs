using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_BSIT31A3_PREFINAL_EXAM_Billena_Dominic.Models;

namespace IT_ELECTIVE_2_BSIT31A3_PREFINAL_EXAM_Billena_Dominic.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Number = 1,
                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Choices = new List<string>
                    {
                        "A. It makes C# code shorter",
                        "B. It prevents the application from restarting",
                        "C. It allows data to persist after the application stops",
                        "D. It removes the need for MVC"
                    },
                    Answer = "C"
                },

                new Question
                {
                    Number = 2,
                    Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Choices = new List<string>
                    {
                        "A. Code-First",
                        "B. Database-First",
                        "C. Model-First",
                        "D. Controller-First"
                    },
                    Answer = "B"
                }
            };

            return View(questions);
        }
    }
}