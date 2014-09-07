using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.BoardState
{
    public class WorldPausedState : State
    {
        AnimalKingdomWorld world;

        public WorldPausedState(AnimalKingdomWorld world)
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
            world.resumeWorld();
            world.state = world.getWorldRunningState;
            world.setWorldStatsText = "World Statistics. State: Running.";
        }

        public void Save()
        {
            world.saveWorld();
        }

        public void Load()
        {
            world.loadWorld();
        }

        public void Pause()
        {

        }
    }
}
