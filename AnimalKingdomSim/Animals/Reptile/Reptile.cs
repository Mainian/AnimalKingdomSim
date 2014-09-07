using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalKingdomSimulator
{
    public abstract class Reptile
    {
        public Reptile()
        {
        }

        public Reptile(int weight, int size, Image picture) 
        {
            this.Weight = weight;
            this.Size = size;
            this.Picture = picture;
        }

        public int Weight
        {
            get;
            set;
        }

        public int Size
        {
            get;
            set;
        }

        public Image Picture
        {
            get;
            set;
        }
    }
}
