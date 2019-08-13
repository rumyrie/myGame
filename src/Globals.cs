using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using myGame.ecs;
using myGame.world;

namespace myGame
{
    public class Globals
    {
        public static SpriteBatch _spriteBatch;
        public static CompManager _compManager;
        public static ContentManager _contentManager;
        public static Map _map;
    }

    public class Constants
    {
        public const int SCREEN_WIDTH = 800;
        public const int SCREEN_HEIGHT = 800;
        public const int CELL_WIDTH = 10;
        public const int CELL_HEIGHT = 10;
    }
}