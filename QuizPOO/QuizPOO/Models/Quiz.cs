using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPOO.Models
{
    public class Quiz : List<Question>
    {
        public Quiz()
        {
            CreationDate = DateTime.Now;
            Pontuation = 0;
        }

        public Quiz(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;
            Pontuation = 0;
        }

        public Quiz(string name, List<Question> quests)
        {
            Name = name;
            Question = quests;
            CreationDate = DateTime.Now;
            Pontuation = 0;
        }

        public void PontuationAdd(int p)
        {
            this.Pontuation += p;
        }

        public int? ShowScore()
        {
            return Pontuation;
        }

        public string? Name { get; set; }
        public List<Question>? Question { get; set; }
        public DateTime? CreationDate { get; set; }
        private int? Pontuation { get; set; }
    }
}
