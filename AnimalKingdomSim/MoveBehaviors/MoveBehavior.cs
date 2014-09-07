using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.MoveBehaviors
{
    public interface MoveBehavior
    {
        void Move(int currentX, int currentY, int boardWidth, int boardHeight, out int newX, out int newY);
    }
}
