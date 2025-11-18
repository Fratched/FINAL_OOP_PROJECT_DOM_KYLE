using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Advanced_Project.Classes.States
{
    public interface IState
    {
        //In some states the pokemon will receive extra damage
        void ExtraDamage(Pokemon pokemon);

        //It increases the chance of catching the Pokemon
        int GetThreshold();
    }
}
