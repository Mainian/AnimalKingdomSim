using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.FightBehaviors
{
    public class Swipe : FightBehavior
    {
        double strgMod = .5;
        double enduranceMod = 1.1;
        double agilMod = 1.4;

        public double Fight(Animal animal)
        {
            return animal.Strength * strgMod + animal.Endurance * enduranceMod + animal.Speed * agilMod;
        }
    }
}
