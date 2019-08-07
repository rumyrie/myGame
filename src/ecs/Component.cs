using System;

namespace myGame.ecs
{
    public abstract class Component
    {
        private Guid _id;

        public Guid Id
        {
            get => this._id;
            set => this._id = value;
        }
    }
}