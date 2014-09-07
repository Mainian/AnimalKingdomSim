using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator
{
    class Gecko : Reptile
    {
        public Gecko(int weight, int size)
        {
            this.Weight = weight;
            this.Size = size;
            this.Picture = getImage();
        }

        public Image getImage()
        {
            Image geckoImg = AnimalKingdomSimulator.Properties.Resources.gecko;
            return geckoImg;
        }
    }
}
