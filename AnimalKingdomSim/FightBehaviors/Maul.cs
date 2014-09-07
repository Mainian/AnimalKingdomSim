using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.FightBehaviors
{
    public class Maul : FightBehavior
    {
        double strgMod = 1.5;
        double enduranceMod = .67;
        double agilMod = .4;

        public double Fight(Animal animal)
        {
            return animal.Strength * strgMod + animal.Endurance * enduranceMod + animal.Speed * agilMod;
        }
    }
}
