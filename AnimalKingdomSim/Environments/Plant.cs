using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Environments
{
    class Plant : Environment
    {
        string myType = "Plant";
        public Plant(int speedIncrease, int strengthIncrease, int enduranceIncrease)
        {
            this.speedIncrease = speedIncrease;
            this.strengthIncrease = speedIncrease;
            this.enduranceIncrease = enduranceIncrease;
        }

        public override Image getImage()
        {
            Image plantImg = AnimalKingdomSimulator.Properties.Resources.plant;
            return plantImg;
        }

        public override int Value()
        {
            return this.strengthIncrease;
        }

        public override string getType()
        {
            return myType;
        }

        public static string getStringType()
        {
            return "Plant";
        }
    }
}
