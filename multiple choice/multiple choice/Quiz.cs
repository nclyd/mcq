using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_choice
{
    class Quiz
    {
        private static string CurrentTopic, CurrentDifficulty;

        public static string currentTopic { get => CurrentTopic; set => CurrentTopic = value; }
        public static string currentDifficulty { get => currentDifficulty; set => currentDifficulty = value; }

        public static List<MultipleChoice> GetMCQs()
        {
            List<MultipleChoice> question = new List<MultipleChoice>();
           
            string[,] mcqs = new string[0,0];



            //read in file for questions#

            for(int i = 0; i <mcqs.GetLength(0); i++)
            {
                MultipleChoice n = new MultipleChoice();
                if (mcqs[i, 6] == currentTopic && mcqs[i, 7] == currentDifficulty)
                {
                    n.QuestionText = mcqs[i, 0];
                    n.possibleAns = mcqs[i, 1];
                    n.possibleAns = mcqs[i, 2];
                    n.possibleAns = mcqs[i, 3];
                    n.possibleAns = mcqs[i, 4];
                    n.answers = mcqs[i, 5];
                    question.Add(n);
                }
            }
            return question;
        }
    }
}
