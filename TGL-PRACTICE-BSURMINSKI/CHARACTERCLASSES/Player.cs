using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGL_PRACTICE_BSURMINSKI.INTERFACES;

namespace TGL_PRACTICE_BSURMINSKI.CHARACTERS
{
    public delegate void OperationDeleg();
    
    public class Player : AbstractPerson, ISkillDefense //ISkillOffense
    {
        public Player()
        {
            healthPoints = 100;
        }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Nickname { get; set; }
        public int healthPoints { get; set; }
        public int Speed { get ; set ; }
        public int Strength { get ; set ; }
        public int Endurance { get ; set ; }
        public int headStrength { get ; set ; }
        public int bodyStrength { get ; set ; }

        //skill
        OperationDeleg dodgeDeleg = new OperationDeleg(Dodge);
        OperationDeleg blockDeleg = new OperationDeleg(Block);
        OperationDeleg jabDeleg = new OperationDeleg(Jab);
        OperationDeleg crossDeleg = new OperationDeleg(Cross);
        OperationDeleg hookDeleg = new OperationDeleg(Hook);
        OperationDeleg uppercutDeleg = new OperationDeleg(Uppercut);

        public static void Block()
        {
            Console.WriteLine("You are blocking strike!!");
        }
        public static void Dodge()
        {
            Console.WriteLine("You are dodging strike!!");
        }
        public static void Jab()
        {
            Console.WriteLine("You are striking Jab!!");
        }
        public static void Cross()
        {
            Console.WriteLine("You are striking Cross!!");
        }

        public static void Hook()
        {
            Console.WriteLine("You are striking Hook!!");
        }
        public static void Uppercut()
        {
            Console.WriteLine("You are striking Uppercut!!");
        }
    }
}
