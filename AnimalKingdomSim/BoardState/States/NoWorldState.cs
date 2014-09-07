using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.BoardState
{
    public class NoWorldState : State
    {
        AnimalKingdomWorld world;

        public NoWorldState(AnimalKingdomWorld world)
        {
            this.world = world;
        }

        public void GenerateWorld()
        {
            world.generateWorld();
            world.state = world.getWorldRunningState;
            world.setWorldStatsText = "World Statistics. State: Running.";
        }

        public void Start()
        {
            
        }

        public void Pause()
        {

        }

        public void Save()
        {

        }

        public void Load()
        {

        }


    }
}
