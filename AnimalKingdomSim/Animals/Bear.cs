using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.FightBehaviors;
using AnimalKingdomSimulator.MoveBehaviors;

namespace AnimalKingdomSimulator
{
    public class Bear : Animal
    {
        public Bear(int speed, int strength, int endurance, MoveBehavior moveBehavior, FightBehavior fightBehavior) : base(speed, strength, endurance, moveBehavior, fightBehavior) { }

        public override Image getImage()
        {
            Image bearImg = AnimalKingdomSimulator.Properties.Resources.bear2;
            return bearImg;
        }
    }
}