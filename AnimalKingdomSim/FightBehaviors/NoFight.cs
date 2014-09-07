using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.FightBehaviors
{
    public class NoFight : FightBehavior
    {
        double strgMod = 0;
        double enduranceMod = 0;
        double agilMod = 0;

        public double Fight(Animal animal)
        {
            return animal.Strength * strgMod + animal.Endurance * enduranceMod + animal.Speed * agilMod;
        }
    }
}
