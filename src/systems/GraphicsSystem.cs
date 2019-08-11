using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using myGame.ecs;

namespace myGame.systems
{
    public class GraphicsSystem
    {
        private GraphicsDevice _gfxDevice;
        private SpriteFont _mapFont;

        public GraphicsSystem(GraphicsDevice gfxDevice)
        {
            this._gfxDevice = gfxDevice;
        }

        public void LoadContent()
        {
            this._mapFont = Globals._contentManager.Load<SpriteFont>("map_chars");
        }

        public void DrawEntity(CompGraphics comp)
        {
            Globals.sprite_batch.DrawString(
                    this._mapFont,
                    comp.Symbol,
                    Globals._compManager.GetScreenPos(comp.Id),
                    comp.Color
                );
        }
        public void DrawAll()
        {
            this._gfxDevice.Clear(Color.Black);
            var drawList = Globals._compManager.GraphicComponentList;

            Globals.sprite_batch.Begin();

            foreach (var comp in drawList)
            {
                DrawEntity(comp.Value);
            }
            Globals.sprite_batch.End();
        }
    }
}