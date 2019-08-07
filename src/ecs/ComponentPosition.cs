using Microsoft.Xna.Framework;

namespace myGame.ecs
{
    public class CompPosition: Component
    {
        private int _map_x;
        private int _map_y;

        public CompPosition(int map_x, int map_y)
        {
            this._map_x = map_x;
            this._map_y = map_y;
        }
        public Vector2 ScreenPos
        {
            get => new Vector2(this._map_x * Constants.CELL_WIDTH, this._map_y * Constants.CELL_HEIGHT);
        }

        public Vector2 MapPos
        {
            get => new Vector2(this._map_x, this._map_y);
            set {
                this._map_x = (int)value.X;
                this._map_y = (int)value.Y;
                }
        }

        public int Map_x
        {
            get => this._map_x;
            set => this._map_x = value;
        }

        public int Map_y
        {
            get => this._map_y;
            set => this._map_y = value;
        }
    }
}