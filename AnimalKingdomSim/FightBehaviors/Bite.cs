using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.FightBehaviors
{
    public class Bite : FightBehavior
    {
        double strgMod = 1;
        double enduranceMod = .37;
        double agilMod = 1.4;

        public double Fight(Animal animal)
        {
            return animal.Strength * strgMod + animal.Endurance * enduranceMod + animal.Speed * agilMod;
        }
    }
}
