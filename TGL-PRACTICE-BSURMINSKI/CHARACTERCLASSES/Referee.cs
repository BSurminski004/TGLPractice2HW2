using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGL_PRACTICE_BSURMINSKI.INTERFACES;

namespace TGL_PRACTICE_BSURMINSKI.CHARACTERS
{
    internal class Referee : AbstractPerson, IJudge
    {
        public Referee()
        {
            Name = "John";
            Surname = "Kowalski";
            Age = 44;
        }
        public Referee(string name, string surname, int age)
        {
            Name = name; Surname = surname; Age = age; 
        }

        public void badStrike(Player p1)
        {
            p1.Points -= 1;
        }

        public int badStrike()
        {
            throw new NotImplementedException();
        }

        public void Clinch()
        {
            throw new NotImplementedException();
        }

        public void Rules()
        {
            throw new NotImplementedException();
        }

        public void Tko()
        {
            throw new NotImplementedException();
        }
    }
}
