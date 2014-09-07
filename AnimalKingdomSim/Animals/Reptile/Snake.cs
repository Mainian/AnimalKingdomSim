using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator
{
    public class Snake : Reptile
    {
        public Snake(int weight, int size)
        {
            this.Weight = weight;
            this.Size = size;
            this.Picture = getImage();
        }

        public Image getImage()
        {
            Image snakeImg = AnimalKingdomSimulator.Properties.Resources.snake;
            return snakeImg;
        }
    }
}