using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL_PRACTICE_BSURMINSKI.INTERFACES
{
    internal interface IJudge
    {
        void Rules(); //method to describe rules of fight
        int badStrike(); //method to decrease points for unfair strikes
        void Clinch(); //method to stop a fight
        void Tko(); //method to end fight when KO 
    }
}
