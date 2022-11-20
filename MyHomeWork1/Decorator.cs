namespace DemoDecorator
{
    public sealed class Lizard
    {
        public int Age { get; set; }

        public string Run()
        {
            return (Age < 20) ? "I have my legs, I can run." : "too old";
        }
    }

    public sealed class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age > 1) ? "I have wings and I can fly." : "too young";
        }
    }

    public class Dragon 
    {
        private int age;
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();

        public int Age
        {
            set
            {
                if (value < 0 || value > 20)
                {
                   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new ArgumentOutOfRangeException(nameof(value),
                      "The valid range is between 0 and 20."));
                    Console.WriteLine();
                    Console.ResetColor();

                    throw new ArgumentOutOfRangeException();
                } 
                                
                age = bird.Age = lizard.Age = value; 
            }
            get { return age; }
        }

        public string Fly()
        {
            return bird.Fly();
        }

        public string Run()
        {
            return lizard.Run();
        }

        public string BreatheFire()
        {
            return "I'm a dragon I can breathe fire.";
        }


    }
}


