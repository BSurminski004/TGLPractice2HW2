using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGL_PRACTICE_BSURMINSKI.INTERFACES;

namespace TGL_PRACTICE_BSURMINSKI.CHARACTERS
{
    internal class Spectator : AbstractPerson //ISpectate
    {
        public Spectator()
        {
            Name = "John";
            Surname = "Wayne";
            Age = 30;
        }
    }
}
