using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.FightBehaviors;
using AnimalKingdomSimulator.MoveBehaviors;

namespace AnimalKingdomSimulator
{
    class Bunny : Animal
    {
        public Bunny(int speed, int strength, int endurance, MoveBehavior moveBehavior, FightBehavior fightBehavior) : base(speed, strength, endurance, moveBehavior, fightBehavior) { }

        public override Image getImage()
        {
            Image bunnyImg = AnimalKingdomSimulator.Properties.Resources.bunny;
            return bunnyImg;
        }
    }
}
