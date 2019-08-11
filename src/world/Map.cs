
using myGame.ecs;
using Microsoft.Xna.Framework;

namespace myGame.world
{
    public class Map
    {
        private int _height;
        private int _width;
        private Entity[,] _tiles;

        public Map(int x, int y)
        {
            this._height = y;
            this._width = x;
            this._tiles = new Entity[this._width, this._height];

            for (var i = 0; i < this._width; i++)
            {
                for (var j = 0; j < this._height; j++)
                {
                    CompGraphics tile;
                    if ((i == 0) || (i == (this._width - 1)) || (j == 0) || (j == (this._height - 1)))
                    {
                        tile = new CompGraphics('#', Color.Brown);
                    }
                    else
                    {
                        tile = new CompGraphics('.', Color.White);
                    }

                    this._tiles[i, j] = new Entity(tile, new CompPosition(i, j));
                }
            }
        }
    }
}