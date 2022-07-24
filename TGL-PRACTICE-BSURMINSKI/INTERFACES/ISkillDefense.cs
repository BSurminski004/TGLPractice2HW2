using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL_PRACTICE_BSURMINSKI.INTERFACES
{
    internal interface ISkillDefense //protect method
    {
        public int Speed { get; set; }
        public int Endurance { get; set; }
        public int headStrength { get; set; }
        public int bodyStrength { get; set; }
    }
}
