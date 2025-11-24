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

        public void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");

        }
    }

    public struct Weapon
    {
        public string name;
        public int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character();
            hero.PrintStatsInfo();
            Character heroine = new Character("Agatha");
            heroine.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            //Testing reference types
            Character villian = hero;

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "Evil evil man";
            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            Weapon warBow = huntingBow;
            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;
            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();
        }
    }
}
