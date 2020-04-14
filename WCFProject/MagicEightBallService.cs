using System;

namespace WCFProject
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question...");
        }

        public String ObtainAnswerToQuestion(String userQuestion)
        {
            String[] answers = { "Future Uncertain", "Yes", "No",
                "Hazy", "Ask again later", "Definitely" };
            // Возвратить случайный ответ.
            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
