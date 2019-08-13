
namespace myGame.world
{
    public class Rectangle
    {
        //left top corner x coord.
        private int x1;
        //left top corner y coord
        private int y1;
        //bottom right corner x coord.
        private int x2;
        //bottom right corner y coord.
        private int y2;

        public Rectangle(int x, int y, int w, int h)
        {
            this.x1 = x;
            this.y1 = y;
            this.x2 = x + w;
            this.y2 = y + h;
        }
    }
}