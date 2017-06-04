using System;
using System.Collections.Generic;
using Core.Attributes;
using Core.Engine;
using Core.Entities;

namespace Core.Systems
{
    public abstract class GameSystem
    {
        private IEnumerable<Type> _relatedAttributesTypes;
        protected GameSystem(List<Type> relatedAttributesTypes)
        {
            
        }
        public abstract void Initialize();
        public abstract void Update();
        public abstract void Shutdown();

        bool TryConstructAttribute(Entity entity, out IEntityAttribute attribute)
        {
            
        }
    }
}