using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace AnimalKingdomSimulator.Environments
{
    class Water : Environment
    {
        string myType = "Water";
        public Water(int speedIncrease, int strengthIncrease, int enduranceIncrease)
        {
            this.speedIncrease = speedIncrease;
            this.strengthIncrease = speedIncrease;
            this.enduranceIncrease = enduranceIncrease;
        }

        public override Image getImage()
        {
            Image waterImg = AnimalKingdomSimulator.Properties.Resources.water;
            return waterImg;
        }

        public override int Value()
        {
            return this.enduranceIncrease;
        }

        public override string getType()
        {
            return myType;
        }

        public static string getStringType()
        {
            return "Water";
        }
    }
}