using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.Environments;

namespace AnimalKingdomSimulator
{
    public class EnviromentFactory :  Observer.Observer
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

        int m_MoveCount;
        int movesSinceLastMove;

        public EnviromentFactory()
        {
            movesSinceLastMove = 2;
        }

        private Environments.Environment makeFruit()
        {
            int i1 = RandomNumber(1, 5);
            Environments.Environment obj = new Fruit(i1, 0, 0);
            obj = addDecorators(obj, i1);
            return obj;
        }
        private Environments.Environment makeWater()
        {
            int i1 = RandomNumber(1, 5);
            Environments.Environment obj = new Water(0, 0, i1);
            obj = addDecorators(obj, i1);
            return obj;
        }
        private Environments.Environment makePlant()
        {
            int i1 = RandomNumber(1, 5);
            Environments.Environment obj = new Plant(0, i1, 0);
            obj = addDecorators(obj, i1);
            return obj;
        }

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

        public void update(int moveCount)
        {
            m_MoveCount = moveCount;
            movesSinceLastMove--;
            if (movesSinceLastMove == 0)
            {
                int x1 = RandomNumber(0, AnimalKingdomWorld.Instance.WorldWidth);
                int y1 = RandomNumber(0, AnimalKingdomWorld.Instance.WorldHeight);

                AnimalKingdomWorld.Instance.PutEnvironment(makeFruit(), x1, y1);

                x1 = RandomNumber(0, AnimalKingdomWorld.Instance.WorldWidth);
                y1 = RandomNumber(0, AnimalKingdomWorld.Instance.WorldHeight);

                AnimalKingdomWorld.Instance.PutEnvironment(makePlant(), x1, y1);

                x1 = RandomNumber(0, AnimalKingdomWorld.Instance.WorldWidth);
                y1 = RandomNumber(0, AnimalKingdomWorld.Instance.WorldHeight);

                AnimalKingdomWorld.Instance.PutEnvironment(makeWater(), x1, y1);

                movesSinceLastMove = 2;
            }            

        }

        private Environments.Environment addDecorators(Environments.Environment obj, int i1)
        {
            if (i1 == 1)
                obj = new Environments.Decorators.Small(obj);
            else if (i1 == 2)
                obj = new Environments.Decorators.Medium(obj);
            else if (i1 == 3)
                obj = new Environments.Decorators.Large(obj);

            int z2 = RandomNumber(0, 3);
            if (z2 == 0)
                obj = new Environments.Decorators.Damaged(obj);
            else if (z2 == 1)
                obj = new Environments.Decorators.Perfect(obj);

            return obj;
        }
    }
}
