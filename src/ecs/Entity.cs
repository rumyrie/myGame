
using System;

namespace myGame.ecs
{
    public class Entity
    {
        private Guid _id;

        public Guid Id
        {
            get => this._id;
        }
        public Entity(params Component[] components)
        {
            this._id = Guid.NewGuid();

            foreach (Component comp in components)
            {
                comp.Id = this._id;
                Globals._compManager.RegisterComponent(comp);
            }
        }
    }
}