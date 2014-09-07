using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.FightBehaviors;
using AnimalKingdomSimulator.MoveBehaviors;

namespace AnimalKingdomSimulator
{
    class Tiger: Animal
    {
        public Tiger(int speed, int strength, int endurance, MoveBehavior moveBehavior, FightBehavior fightBehavior) : base(speed, strength, endurance, moveBehavior, fightBehavior) { }

        public override Image getImage()
        {
            Image tigerImg = AnimalKingdomSimulator.Properties.Resources.tiger;
            return tigerImg;
        }
    }
}
