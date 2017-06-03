using System.Collections;
using System.Collections.Generic;
using Core.Entities;
using Core.Systems;

namespace Core.Engine
{
    public class Engine
    {
        private List<IGameSystem> _systems;
        private List<Entity> _entities;
        private HashSet<IComponentNode> _componentNodes;

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
