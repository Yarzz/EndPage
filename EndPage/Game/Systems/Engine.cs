using System.Collections.Generic;

namespace Game.Systems
{
    public class Engine : IEngine
    {
        private List<IGameSystem> _systems;

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
