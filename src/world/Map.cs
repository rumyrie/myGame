
using myGame.ecs;
using Microsoft.Xna.Framework;

namespace myGame.world
{
    public class Map
    {
        private int _height;
        private int _width;
        private Tile[,] _tiles;

        public Map(int x, int y)
        {
            this._height = y;
            this._width = x;
            this._tiles = new Tile[this._width, this._height];

            for (var i = 0; i < this._width; i++)
            {
                for (var j = 0; j < this._height; j++)
                {
                    this._tiles[i, j] = new Tile(
                        true, true, new CompGraphics('#', Color.Brown), new CompPosition(i, j)
                    );
                }
            }
        }

        public bool IsBlocked(int x, int y)
        {
            return this._tiles[x, y].Block;
        }
    }
}