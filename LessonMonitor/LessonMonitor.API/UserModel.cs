using LessonMonitor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LessonMonitor.API
{
    public class UserModel<T>
    {
        public string Title { get; set; }
        public List<string> Properties { get; set; }

        public UserModel(T model)
        {
            Title = GetClassTitle(model);
            Properties = GetClassProperties(model);
        }

        private string GetClassTitle (T model)
        {
            Type t = model.GetType();
            string result = t.Name;

            return result;
        }

        private List<string> GetClassProperties(T model)
        {
            Type t = model.GetType();
            PropertyInfo[] properties = t.GetProperties();

            var result = new List<string>();

            foreach (var property in properties)
            {
                result.Add(property.Name);
            }
            return result;
        }
    }
}
