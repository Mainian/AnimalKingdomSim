using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator
{
    class Croc : Reptile
    {
        public Croc(int weight, int size)
        {
            this.Weight = weight;
            this.Size = size;
            this.Picture = getImage();
        }

        public Image getImage()
        {
            Image crocImg = AnimalKingdomSimulator.Properties.Resources.croc;
            return crocImg;
        }
    }
}