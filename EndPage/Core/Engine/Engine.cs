using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Core.Attributes;
using Core.Entities;
using Core.Systems;

namespace Core.Engine
{
    public class Engine
    {
        private readonly List<GameSystem> _systems;
        private List<Entity> _entities;
        private IEntityAttributesBuilder _attributesBuilder;

        public Engine(IEntityAttributesBuilder attributesBuilder)
        {
            _attributesBuilder = attributesBuilder;
            _systems = new List<GameSystem>();
            _entities = new List<Entity>();
        }

        public void MainLoop()
        {
            UpdateSystems();
        }

        public void UpdateSystems()
        {
            _systems.ForEach(gameSystem=>gameSystem.Update());   
        }

        public void AddSystem(GameSystem system)
        {
            _systems.Add(system);
            system.Initialize();
        }

        public void RemoveSystem(GameSystem system)
        {
            system.Shutdown();
            _systems.Remove(system);
        }

        public void AddEntity(Entity entity)
        {
            var entityAttributes = _attributesBuilder.ConstructAttributesFromEntity(entity, _systems);
            _entities.Add(entity);
        }

        public void RemoveEntity(Entity entity)
        {
            _entities.Remove(entity);
        }
        public List<IEntityAttribute> GetAttributes<T>()
        {
            throw new NotImplementedException();
        }
    }
}
