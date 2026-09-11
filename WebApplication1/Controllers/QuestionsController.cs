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
                },

                new Question
                {
                    Number = 3,
                    Text = "What is the primary purpose of Entity Framework Core (EF Core)?",
                    Choices = new List<string>
                    {
                        "A. To create HTML pages",
                        "B. To replace the Controller",
                        "C. To map objects in code to data in a relational database",
                        "D. To replace the C# compiler"
                    },
                    Answer = "C"
                },

                new Question
                {
                    Number = 4,
                    Text = "Which EF Core component is responsible for communicating with the database?",
                    Choices = new List<string>
                    {
                        "A. DbContext",
                        "B. DbSetView",
                        "C. ControllerContext",
                        "D. RazorContext"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 5,
                    Text = "What does the following command do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Choices = new List<string>
                    {
                        "A. Deletes the database",
                        "B. Creates a new MVC project",
                        "C. Generates EF Core models and a DbContext from an existing database",
                        "D. Starts the application"
                    },
                    Answer = "C"
                }
            };

            return View(questions);
        }
    }
}