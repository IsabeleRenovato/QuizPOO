using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace QuizPOO.Models
{
    public class Question
    {
        public Question()
        {
            Id += 1;
            this.Option = new Dictionary<string, string>();
            this.Power = new Dictionary<string, int>();
        }

        public int Id { get; set; }
        public string? Pergunta { get; set; }
        public int? Answer { get; set; }
        public Dictionary<string, string> Option { get; set; }
        public Dictionary<string, int> Power { get; set; }
    }
}
