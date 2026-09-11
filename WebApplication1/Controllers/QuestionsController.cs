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
                // 1-5: Relational Data Modeling, Model Binding, and Controller Actions

                new Question
                {
                    Number = 1,
                    Text = "What is the main purpose of a table in a relational database?",
                    Choices = new List<string>
                    {
                        "A. To store related data in rows and columns",
                        "B. To display HTML pages",
                        "C. To execute C# code",
                        "D. To handle HTTP requests"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 2,
                    Text = "Which key uniquely identifies each record in a relational database table?",
                    Choices = new List<string>
                    {
                        "A. Foreign key",
                        "B. Primary key",
                        "C. Candidate view",
                        "D. Navigation key"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 3,
                    Text = "Which constraint prevents duplicate values from being stored in a column?",
                    Choices = new List<string>
                    {
                        "A. UNIQUE",
                        "B. DEFAULT",
                        "C. CHECK",
                        "D. NULL"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 4,
                    Text = "What is Model Binding in ASP.NET Core MVC?",
                    Choices = new List<string>
                    {
                        "A. Automatically mapping request data to action parameters or model objects",
                        "B. Creating database tables from HTML",
                        "C. Connecting a View directly to a database",
                        "D. Converting a Controller into a Model"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 5,
                    Text = "What is the main purpose of a Controller Action in ASP.NET Core MVC?",
                    Choices = new List<string>
                    {
                        "A. To handle HTTP requests and return an appropriate response",
                        "B. To permanently store data in the database",
                        "C. To create HTML tags automatically",
                        "D. To replace the Model"
                    },
                    Answer = "A"
                },

                // 6-10: ERD, Razor Syntax, and Dynamic Rendering

                new Question
                {
                    Number = 6,
                    Text = "What does an Entity-Relationship Diagram (ERD) primarily represent?",
                    Choices = new List<string>
                    {
                        "A. Entities, their attributes, and relationships",
                        "B. C# program code",
                        "C. HTML page layouts only",
                        "D. Computer hardware specifications"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 7,
                    Text = "In an ERD, what does an entity generally represent?",
                    Choices = new List<string>
                    {
                        "A. A real-world object or concept that can be stored as data",
                        "B. A programming loop",
                        "C. A web browser",
                        "D. A controller action"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 8,
                    Text = "Which symbol is used to begin a C# code expression in a Razor view?",
                    Choices = new List<string>
                    {
                        "A. #",
                        "B. @",
                        "C. $",
                        "D. &"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 9,
                    Text = "Which Razor structure is commonly used to display multiple records dynamically?",
                    Choices = new List<string>
                    {
                        "A. @foreach",
                        "B. @database",
                        "C. @table",
                        "D. @record"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 10,
                    Text = "Which Razor statement can be used to display content only when a condition is true?",
                    Choices = new List<string>
                    {
                        "A. @foreach",
                        "B. @if",
                        "C. @model",
                        "D. @using"
                    },
                    Answer = "B"
                },

                // 11-15: Normalization, Data Validation, and ModelState

                new Question
                {
                    Number = 11,
                    Text = "What is the main goal of database normalization?",
                    Choices = new List<string>
                    {
                        "A. To reduce data redundancy and improve data integrity",
                        "B. To duplicate data across tables",
                        "C. To remove relationships between tables",
                        "D. To store everything in one table"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 12,
                    Text = "Which normal form requires each field to contain only atomic values and no repeating groups?",
                    Choices = new List<string>
                    {
                        "A. First Normal Form (1NF)",
                        "B. Second Normal Form (2NF)",
                        "C. Third Normal Form (3NF)",
                        "D. Fourth Normal Form (4NF)"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 13,
                    Text = "Which normal form requires a table to be in 1NF and have no partial dependencies on a composite primary key?",
                    Choices = new List<string>
                    {
                        "A. 1NF",
                        "B. 2NF",
                        "C. 3NF",
                        "D. BCNF"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 14,
                    Text = "Which normal form removes transitive dependencies from a table?",
                    Choices = new List<string>
                    {
                        "A. 1NF",
                        "B. 2NF",
                        "C. 3NF",
                        "D. 4NF"
                    },
                    Answer = "C"
                },

                new Question
                {
                    Number = 15,
                    Text = "What does ModelState.IsValid determine in an ASP.NET Core MVC Controller?",
                    Choices = new List<string>
                    {
                        "A. Whether the submitted model passed validation",
                        "B. Whether the database server is online",
                        "C. Whether the Controller exists",
                        "D. Whether the View contains HTML"
                    },
                    Answer = "A"
                },

                // 16-20: SQL, In-Memory Data Storage, and CRUD Operations

                new Question
                {
                    Number = 16,
                    Text = "Which SQL command is used to retrieve records from a database table?",
                    Choices = new List<string>
                    {
                        "A. INSERT",
                        "B. SELECT",
                        "C. UPDATE",
                        "D. DELETE"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 17,
                    Text = "Which SQL command is used to add a new record to a table?",
                    Choices = new List<string>
                    {
                        "A. SELECT",
                        "B. INSERT",
                        "C. UPDATE",
                        "D. DELETE"
                    },
                    Answer = "B"
                },

                new Question
                {
                    Number = 18,
                    Text = "In CRUD operations, which operation represents changing an existing record?",
                    Choices = new List<string>
                    {
                        "A. Create",
                        "B. Read",
                        "C. Update",
                        "D. Delete"
                    },
                    Answer = "C"
                },

                new Question
                {
                    Number = 19,
                    Text = "Which C# collection can be used to temporarily store multiple objects in memory while an application is running?",
                    Choices = new List<string>
                    {
                        "A. List<T>",
                        "B. Database",
                        "C. SQL Server",
                        "D. Foreign Key"
                    },
                    Answer = "A"
                },

                new Question
                {
                    Number = 20,
                    Text = "Which CRUD operation removes an existing record from a collection or data source?",
                    Choices = new List<string>
                    {
                        "A. Create",
                        "B. Read",
                        "C. Update",
                        "D. Delete"
                    },
                    Answer = "D"
                }
            };

            return View(questions);
        }
    }
}