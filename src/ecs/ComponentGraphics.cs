
namespace myGame.ecs
{
    public class CompGraphics: Component
    {
        private char _c;
        //private Color _color;

        public string Symbol
        {
            get => this._c.ToString();
        }

        public CompGraphics(char c)
        {
            this._c = c;
        }
    }
}