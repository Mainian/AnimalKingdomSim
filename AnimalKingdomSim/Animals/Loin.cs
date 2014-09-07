using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.FightBehaviors;
using AnimalKingdomSimulator.MoveBehaviors;

namespace AnimalKingdomSimulator
{
    class Lion : Animal
    {
        public Lion(int speed, int strength, int endurance, MoveBehavior moveBehavior, FightBehavior fightBehavior) : base(speed, strength, endurance, moveBehavior, fightBehavior) { }

        public override Image getImage()
        {
            Image lionImg = AnimalKingdomSimulator.Properties.Resources.lion;
            return lionImg;
        }
    }
}
