using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.Environments;

namespace AnimalKingdomSimulator.Environments
{
    class Fruit : Environment
    {
        string myType = "Fruit";
        public Fruit(int speedIncrease, int strengthIncrease, int enduranceIncrease)
        {
            this.speedIncrease = speedIncrease;
            this.strengthIncrease = speedIncrease;
            this.enduranceIncrease = enduranceIncrease;
        }

        public override Image getImage()
        {
            Image fruitImg = AnimalKingdomSimulator.Properties.Resources.fruit;
            return fruitImg;
        }

        public override int Value()
        {
            return this.speedIncrease;
        }

        public override string getType()
        {
            return myType;
        }

        public static string getStringType()
        {
            return "Fruit";
        }
    }
}
