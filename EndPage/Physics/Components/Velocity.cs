using System.Numerics;
using Core.Components;

namespace Physics.Components
{
    public class Velocity : IEntityComponent
    {
        public Vector2 VelocityVector { get; set; }

        public Velocity()
        {
            VelocityVector = Vector2.Zero;
        }

        public Velocity(float x, float y)
        {
            VelocityVector = new Vector2(x, y);
        }
    }
}
