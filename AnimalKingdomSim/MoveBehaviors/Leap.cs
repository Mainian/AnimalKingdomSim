using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AnimalKingdomSimulator.MoveBehaviors
{
    class Leap : MoveBehavior
    {
        private static readonly Random random = new Random();
        //private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            //lock (syncLock)
            //{
            return random.Next(min, max);
            //}
        }

        public void Move(int currentX, int currentY, int boardWidth, int boardHeight, out int newX, out int newY)
        {
            newX = 0; newY = 0;
            int minX = -1; int maxX = 2;
            int minY = -1; int maxY = 2;

            Random random = new Random();
            if (currentX == 0)
                minX = minX + 1;
            if (currentX == (boardWidth - 1))
                maxX = maxX - 1;

            if (currentY == 0)
                minY = minY + 1;
            if (currentY == (boardHeight - 1))
                maxY = maxY - 1;

            int randY = 0;
            int randX = 0;
            do
            {
                randX = RandomNumber(minX, maxX);
                newX = randX + currentX;

                randY = RandomNumber(minY, maxY);
                newY = randY + currentY;
            }
            while (newX == currentX && newY == currentY);
        }
    }
}
