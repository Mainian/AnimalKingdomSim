using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.FightBehaviors
{
    public interface FightBehavior
    {
        double Fight(Animal animal);
    }
}