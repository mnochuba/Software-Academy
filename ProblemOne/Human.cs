namespace ProblemOne
{
    public class Human
    {
        public Human()
        {
            
        }

        public Human(Programme programme)
        {
            Programme = programme;
        }

        public Human(Programme programme, string name) : this(programme)
        {
            Name = name;
        }

        public void AttendClass(WeekDay classDay)
        {
            if (Programme.ClassDays.Contains(classDay))
            {
                Console.WriteLine("The host will let you in shortly");
                Thread.Sleep(5000);
                Console.WriteLine("You're in!");
            }
            else
            {
                Console.WriteLine("No class today!");
            }
        }

        public virtual void AskQuestion(Human human)
        {
            Console.WriteLine("I am asking a question");
        }


        public virtual void AnswerQuestion()
        {
            Console.WriteLine("I am giving explanations");
        }

        public string Name { get; set; }





        public Programme Programme { get; set; }
    }

    public class Circle
    {
        public Circle()
        {
            radius = 5;
        }


        private double radius;

        public double Area
        {
            get { return Math.PI * radius * radius; }
            set { radius = value; }
        }
    }
}