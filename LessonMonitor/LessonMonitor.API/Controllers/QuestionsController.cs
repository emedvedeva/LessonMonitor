using LessonMonitor.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase

    {
        private List<Question> _questions;

        public QuestionsController()
        {
            _questions = new List<Question>
            {
                new Question("question1", "Михаил Кодер", new DateTime(2021, 2, 13, 15, 30, 25)),
                new Question("question2", "Михаил Кодер", new DateTime(2021, 2, 13, 15, 45, 25)),
                new Question("question3", "SHILY", new DateTime(2021, 2, 13, 16, 30, 25))
            };
        }

        [HttpGet]
        public IActionResult Get(string memberName)
        {
            var result = _questions.Where(x => x.MemberName == memberName)
                .ToArray();
            return Ok(result);
        }
    }
}
