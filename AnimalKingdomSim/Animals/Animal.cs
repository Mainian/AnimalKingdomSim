using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AnimalKingdomSimulator.MoveBehaviors;
using AnimalKingdomSimulator.FightBehaviors;


namespace AnimalKingdomSimulator
{
    public abstract class Animal : GridObject, Observer.Observer
    {
        public FightBehavior fight;
        public MoveBehavior move;
        int m_moveCount;
        int movesSinceLastMove;

        public Animal(int speed, int strength, int endurance, MoveBehavior moveBehaivor, FightBehavior fightBehavior)
        {
            this.Speed = speed;
            this.Strength = strength;
            this.Endurance = endurance;
            this.move = moveBehaivor;
            this.fight = fightBehavior;
        }

        public int Speed
        {
            get;
            set;
        }

        public int Strength
        {
            get;
            set;
        }

        public int Endurance
        {
            get;
            set;
        }

        public void update(int moveCount)
        {
            this.m_moveCount = moveCount;
            movesSinceLastMove++;
            if(movesSinceLastMove - Speed%10 <= 0)
            {
                performMove();
            }
            movesSinceLastMove = 0;

        }

        public double performFight()
        {
            return fight.Fight(this);
        }

        public void performMove()
        {
            int newX;
            int newY;
            move.Move(xCordinate, yCordinate, AnimalKingdomWorld.Instance.WorldWidth, AnimalKingdomWorld.Instance.WorldHeight, out newX, out newY);
            AnimalKingdomWorld.Instance.MakeMove(this, newX, newY);
        }

        public void performEat(Environments.Environment environment)
        {

            if (environment.GetType().Equals(typeof(Environments.Fruit)))
            {
                this.Speed += environment.Value();
            }
            if (environment.GetType().Equals(typeof(Environments.Plant)))
            {
                this.Strength += environment.Value();
            }
            if (environment.GetType().Equals(typeof(Environments.Water)))
            {
                this.Endurance += environment.Value();
            }
        }

        public Animal clone()
        {
            return (Animal)this.MemberwiseClone();
        }
    }
}
