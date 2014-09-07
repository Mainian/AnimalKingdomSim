using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.BoardState
{
    public class WorldRunningState : State
    {
        AnimalKingdomWorld world;

        public WorldRunningState(AnimalKingdomWorld world)
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
            world.pauseWorld();
            world.state = world.getWorldPausedState;
            world.setWorldStatsText = "World Statistics. State: Paused.";
        }

        public void Load()
        {

        }

        public void Save()
        {

        }
    }
}
