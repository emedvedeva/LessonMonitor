using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.API.Models
{
    public class Question
    {
        public string Discription { get; set; }
        public string MemberName { get; set; }
        public DateTime LessonDate { get; set; }
        public Question(string discription, string memberName, DateTime lessonDate)
        {
            Discription = discription;
            MemberName = memberName;
            LessonDate = lessonDate;
        }
    }
}
