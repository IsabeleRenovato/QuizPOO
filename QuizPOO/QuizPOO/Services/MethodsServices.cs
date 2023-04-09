using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QuizPOO.Models;
using QuizPOO.Services.Interfaces;

namespace QuizPOO.Services
{
    public class MethodsServices : IMethodsServices
    {
        public void SetWinxs(int? pont)
        {
            if (pont > 0 && pont <= 45)
            {
                Console.WriteLine("Bloom é uma personagem do Clube das Winx. Ela é protagonista da série e é a líder informal das Winx, assim como a princesa de Domino e a detentora da Chama do Dragão.");
            }
            else if (pont > 45 && pont <= 65)
            {
                Console.WriteLine("Musa é uma fada da música, ela nasceu em melody Musa faz muita coisa, ela dança, canta e toca todos os instrumentos, mas o seu favorito é a flauta de concerto.");
            }
            else if (pont > 65 && pont <= 80)
            {
                Console.WriteLine("Flora é uma personagem do Clube das Winx. Ela é a Fada da Natureza, e é uma das melhores amigas de Bloom. Flora é uma garota doce e gentil; e tem vários amigos por isso");
            }
            else if (pont > 80)
            {
                Console.WriteLine("Stella é princesa e fada guardiã de Solaria, também é guardiã do Anel de Solaria e fada do Sol e da Lua.");
            }

        }

        public string ShowMenu(List<Models.Quiz> quiz)
        {
            Console.WriteLine("Escolha o quiz desejado: ");
            var i = 1;
            var resp = quiz.Count + 1;
            foreach (var item in quiz)
            {
                Console.WriteLine($" {i} - {item.Name}");
                i++;
            }

            resp = Convert.ToInt32(Console.ReadLine());

            var selectedQuiz = quiz.FirstOrDefault(q => q.Name == quiz[resp-1].Name).Name;

            return selectedQuiz;
        }

        public void ShowQuiz(Quiz? quizz)
        {
            var i = 1;
            Console.WriteLine($"{quizz.Name}");

            foreach (var item in quizz.Question)
            {
                Console.WriteLine($"Pergunta {i}:");
                Console.WriteLine(item.Pergunta);
                Console.WriteLine(String.Join("\n\r", item.Option));

                var opt = Console.ReadLine();

                

                int pont = Convert.ToInt32(item.Power.GetValueOrDefault(opt.ToUpper()));


                quizz.PontuationAdd(pont);

                i++;
            }
        }
    }
}
