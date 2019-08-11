
using Microsoft.Xna.Framework;

namespace myGame.ecs
{
    public class CompGraphics : Component
    {
        private char _c;
        private Color _color;

        public string Symbol
        {
            get => this._c.ToString();
            set => this._c = value[0];
        }

        public Color Color
        {
            get => this._color;
        }

        public CompGraphics(char c, Color color)
        {
            this._c = c;
            this._color = color;
        }
    }
}