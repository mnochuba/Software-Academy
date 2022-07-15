namespace ProblemOne
{
    public class Facilitator : Human
    {
        public Facilitator(Programme programme) : base(programme)
        {
        }

        public Facilitator(Programme programme, string name): base(programme,name)
        {
        }

        public override void AskQuestion(Human human)
        {
            if (human is Student)
            {
                base.AskQuestion(human);
            }
            else if (human is Facilitator)
            {
                Console.WriteLine("Facilitator cannot ask facilitator");
            }
        }
        public override void AnswerQuestion()
        {
            base.AnswerQuestion();
            Console.WriteLine("Here are some extra resources");
        }
    }
}