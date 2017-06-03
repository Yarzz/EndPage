using System.Collections;
using System.Collections.Generic;
using Game.Entities;

namespace Game.Systems
{
    public class Engine
    {
        private List<IGameSystem> _systems;
        private List<Entity> _entities;
        private Dictionary<IComponentNode>

        public Engine()
        {
            _systems = new List<IGameSystem>();
        }
        public void MainLoop()
        {
            UpdateSystems();
        }

        public void UpdateSystems()
        {
            foreach (var gameSystem in _systems)
            {
                gameSystem.Update();
            }
        }

        public void AddSystem(IGameSystem system)
        {
            if (system != null)
                _systems.Add(system);
        }
    }
}
