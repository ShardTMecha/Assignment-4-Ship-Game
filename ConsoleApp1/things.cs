using Raylib_cs;
using System.Numerics;

namespace ConsoleApp1
{
    internal class things
    {
        public Vector2 postion ;
        private Color color { get; }

        public things(Color color) 
        {
            this.color = color;
        }

        public void Draw()
        {
            Raylib.DrawCircleV(postion, 15,color);
        }
    }
}
