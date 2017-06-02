using System.Numerics;
using Game.Components;

namespace Physics.Components
{
    public class Velocity : IGameComponent
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
