using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalKingdomSimulator
{
    public class ReptileAdapter: Animal
    {
        Reptile reptile;

        public ReptileAdapter(Reptile reptile)
            : base((int)((2.0 / 3.0) * reptile.Size + (3.0 / 2.0) * reptile.Weight), (int)reptile.Size*reptile.Weight, 
            (int)2.0*reptile.Size/reptile.Weight, new MoveBehaviors.Slither(), new FightBehaviors.Bite())
        {
            this.reptile = reptile;
        }

        public override Image getImage()
        {
            Image reptileImage = reptile.Picture;
            return reptileImage;
        }

        public Object type()
        {
            return reptile;
        }
    }
}
