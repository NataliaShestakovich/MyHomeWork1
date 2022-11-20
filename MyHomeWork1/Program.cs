
namespace DemoDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dragonAis = new Dragon()
            {
                Age = 10
            };

            Console.WriteLine(dragonAis.Fly());

            Console.WriteLine(dragonAis.Run());

            Console.WriteLine(dragonAis.BreatheFire());
        }

    }
}