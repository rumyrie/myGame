
namespace myGame.ecs
{
    public class CompGraphics : Component
    {
        private char _c;

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