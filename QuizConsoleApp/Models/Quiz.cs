using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleApp.Models
{
    internal class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
       


        public Quiz(string name)
        {
            Name = name;
        }
    }
}
