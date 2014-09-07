using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Environments
{
    public abstract class Environment : GridObject
    {


        public int speedIncrease
        {
            get;
            set;
        }

        public int strengthIncrease
        {
            get;
            set;
        }

        public int enduranceIncrease
        {
            get;
            set;
        }

        public abstract int Value();

        public abstract string getType();

        public Environment clone()
        {
            return (Environment)this.MemberwiseClone();
        }
    }
}
