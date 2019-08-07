using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using myGame.ecs;

namespace myGame
{
    public class Globals
    {
        public static SpriteBatch sprite_batch;
        public static CompManager _compManager;
        public static ContentManager _contentManager;
    }

    public class Constants
    {
        public const int SCREEN_WIDTH = 640;
        public const int SCREEN_HEIGHT = 640;
        public const int CELL_WIDTH = 16;
        public const int CELL_HEIGHT = 16;
    }
}