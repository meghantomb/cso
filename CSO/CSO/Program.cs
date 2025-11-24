namespace CSO
{
    public class Character
    {
        public string name;
        public int exp;

        public Character()
        {
            name = "Not assigned";
        }

        public Character(string name)
        {
            this.name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character();
            Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");

            Character heroine = new Character("Agatha");
            Console.WriteLine("Hero: " + heroine.name + " - " + heroine.exp + " EXP");

        }
    }
}
