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
                },

                new Question
                {
                    Number = 6,
                    Text = "Where is the connection string commonly stored in an ASP.NET Core application?",
                    Choices = new List<string>
                    {
                        "A. Program.cs only",
                        "B. appsettings.json",
                        "C. Index.cshtml",
                        "D. Student.cs"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 7,
                    Text = "A Student belongs to exactly one Section, while a Section can have many Students. What type of relationship is this?",
                    Choices = new List<string>
                    {
                        "A. One-to-one",
                        "B. One-to-many",
                        "C. Many-to-many",
                        "D. Many-to-one"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 8,
                    Text = "In a Student entity, what does SectionId represent when it references the Section entity?",
                    Choices = new List<string>
                    {
                        "A. Primary key of Student",
                        "B. Foreign key referencing Section",
                        "C. Navigation property",
                        "D. Database connection string"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 9,
                    Text = "What is the purpose of a navigation property in an EF Core entity?",
                    Choices = new List<string>
                    {
                        "A. It stores the database connection string",
                        "B. It represents a relationship to another entity",
                        "C. It replaces the primary key",
                        "D. It creates a new controller"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 10,
                    Text = "What is the purpose of the Include() method in Entity Framework Core?",
                    Choices = new List<string>
                    {
                        "A. To delete related records",
                        "B. To load related data along with the main entity",
                        "C. To create a new database",
                        "D. To validate user input"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 11,
                    Text = "When should a ViewModel be used when displaying Student and Section information?",
                    Choices = new List<string>
                    {
                        "A. When the database needs to be deleted",
                        "B. When combining or shaping data specifically needed by the view",
                        "C. When creating a new controller",
                        "D. When replacing Entity Framework Core"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 12,
                    Text = "What is the benefit of using _context.Students.Include(s => s.Section).ToList()?",
                    Choices = new List<string>
                    {
                        "A. It loads the related Section navigation property along with the Students",
                        "B. It deletes all Section records",
                        "C. It creates a new Student table",
                        "D. It validates the Student input"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 13,
                    Text = "What type of validation occurs in the browser before a request is sent to the server?",
                    Choices = new List<string>
                    {
                        "A. Database validation",
                        "B. Client-side validation",
                        "C. Server-side validation",
                        "D. Controller validation"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 14,
                    Text = "Why is server-side validation still necessary even when client-side validation is used?",
                    Choices = new List<string>
                    {
                        "A. Client-side validation can be bypassed",
                        "B. Server-side validation makes HTML pages shorter",
                        "C. Client-side validation replaces the database",
                        "D. Server-side validation prevents the application from restarting"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 15,
                    Text = "Which field should be unique for identifying each Student record?",
                    Choices = new List<string>
                    {
                        "A. Student Number",
                        "B. Student Name",
                        "C. Section Name",
                        "D. Course Name"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 16,
                    Text = "Why should a unique constraint be applied at the database level?",
                    Choices = new List<string>
                    {
                        "A. It protects data integrity even if application validation is bypassed",
                        "B. It makes the application restart faster",
                        "C. It removes the need for a database",
                        "D. It automatically creates a controller"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 17,
                    Text = "What is the purpose of using try/catch in a controller?",
                    Choices = new List<string>
                    {
                        "A. To create database tables",
                        "B. To catch and handle exceptions that occur during execution",
                        "C. To replace the Model",
                        "D. To generate HTML pages"
                    },
                    Answer = "B"
                }
            };

            return View(questions);
        }
    }
}