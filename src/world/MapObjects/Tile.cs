
using myGame.ecs;

namespace myGame.world
{
    public class Tile : Entity
    {
        //_block == true -> blocks movement
        private bool _block = true;
        //_blockSith == true -> blocks FOV
        private bool _blockSight = true;

        public Tile(bool block, bool blockSight, params Component[] components) : base(components)
        {
            this._block = block;
            this._blockSight = blockSight;
        }

        public bool Block
        {
            get => this._block;
        }
    }
}