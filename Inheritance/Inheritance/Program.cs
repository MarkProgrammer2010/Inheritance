using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior character1 = new Warrior("Jack", 100, 25, 50);
            character1.ShowInfo();

            Console.WriteLine(  );

            Archer character2 = new Archer("Bob", 75, 35);
            character2.ShowInfo();           
        }
    }

    public class Character
    {
        private string _name;
        private int _health;
        private int _damage;

        public Character(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}\nHealth: {_health}\nDamage: {_damage}");
        }
    }

    public class Warrior : Character
    {
        private int _defRate;

        public Warrior(string name, int health, int damage, int defRate) : base(name, health, damage)
        {
            _defRate = defRate;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Def rate: {_defRate}");
        }
    }

    public class Archer : Character
    {
        private int _arrowsCount;

        public Archer(string name, int health, int damage) : base(name, health, damage)
        {
            _arrowsCount = 30;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Arrows left: {_arrowsCount}");
        }
    }
}
