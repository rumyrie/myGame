using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using myGame.ecs;
using myGame.systems;
using myGame.world;

namespace myGame
{

    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game())
                game.Run();
        }
    }

    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        GraphicsSystem gfxSystem;

        Entity player;
        Guid playerID;
        public Game()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            //pretty much self-explainatory
            //it sets screen resolution
            graphics.PreferredBackBufferHeight = Constants.SCREEN_HEIGHT;
            graphics.PreferredBackBufferWidth = Constants.SCREEN_WIDTH;
            graphics.ApplyChanges();

            Globals._compManager = new CompManager();
            Globals._contentManager = this.Content;
            this.gfxSystem = new GraphicsSystem(this.GraphicsDevice);

            Globals._map = new Map(30, 30);
            player = new Entity(new CompPosition(10, 10), new CompGraphics('@', Color.Red));
            this.playerID = player.Id;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals._spriteBatch = new SpriteBatch(GraphicsDevice);
            this.gfxSystem.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                Globals._compManager.MoveEntity(playerID, -1, 0);
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                Globals._compManager.MoveEntity(playerID, 1, 0);
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                Globals._compManager.MoveEntity(playerID, 0, -1);
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                Globals._compManager.MoveEntity(playerID, 0, 1);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.gfxSystem.DrawAll();
            base.Draw(gameTime);
        }
    }
}
