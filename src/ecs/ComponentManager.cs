using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace myGame.ecs
{
    public class CompManager
    {
        private Dictionary<Guid, CompPosition> _compPos;
        private Dictionary<Guid, CompGraphics> _compGfx;

        public Dictionary<Guid, CompGraphics> GraphicComponentList
        {
            get => _compGfx;
        }

        public Dictionary<Guid, CompPosition> PosComponentList
        {
            get => _compPos;
        }

        public CompManager()
        {
            this._compGfx = new Dictionary<Guid, CompGraphics>();
            this._compPos = new Dictionary<Guid, CompPosition>();
        }

        public Vector2 GetScreenPos(Guid id)
        {
            var x = this._compPos[id].ScreenPos;
            return x;
        }

        public void MoveEntity(Guid id, int dx, int dy)
        {
            if (!Globals._map.IsBlocked(this._compPos[id].Map_x + dx, _compPos[id].Map_y + dy))
            {
                this._compPos[id].Map_x += dx;
                this._compPos[id].Map_y += dy;
            }
        }

        public void RegisterComponent(Component component)
        {
            if (component is CompPosition)
            {
                this._compPos.Add(component.Id, component as CompPosition);
            }
            else if (component is CompGraphics)
            {
                this._compGfx.Add(component.Id, component as CompGraphics);
            }
        }
    }
}