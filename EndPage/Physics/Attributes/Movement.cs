using Core.Attributes;
using Physics.Components;

namespace Physics.Attributes
{
    public class Movement : IEntityAttribute
    {
        public Position Position { get; set; }
        public Velocity Velocity { get; set; }
    }
}
