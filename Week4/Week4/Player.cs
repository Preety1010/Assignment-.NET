using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Player
    {
        // Instance fields
        public string playerName;
        public int level;
        public int health;

        // Default constructor
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor
        public Player(string name, int lvl, int hp)
        {
            playerName = name;
            level = lvl;
            health = hp;
        }
    }
}
