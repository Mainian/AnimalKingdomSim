using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AnimalKingdomSimulator
{
    public abstract class GridObject
    {
        public Image image
        {
            get;
            set;
        }

        public int xCordinate
        {
            get;
            set;
        }

        public int yCordinate
        {
            get;
            set;
        }

        public abstract Image getImage();
    }
}
