using System;

namespace Arqan.Example2
{
    public class Block
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Direction { get; set; }
        public bool UseDelta { get; set; }

        private readonly float r;
        private readonly float g;
        private readonly float b;

        public Block(float x, float y)
        {
            this.X = x;
            this.Y = y;

            r = (new Random().Next(0, 255)) / 255f;
            g = (new Random().Next(0, 255)) / 255f;
            b = (new Random().Next(0, 255)) / 255f;
            Direction = new Random().Next(0, 3);
        }

        public void Update(double deltaTime, float windowWidth, float windowHeight)
        {
            var speed = UseDelta ? 60 * deltaTime : 1;

            if (X > windowWidth - 32) Direction = 1;
            if (X < 0) Direction = 0;
            if (Y > windowHeight - 32) Direction = 3;
            if (Y < 0) Direction = 2;

            if (Direction == 0) X += speed;
            if (Direction == 1) X -= speed;
            if (Direction == 2) Y += speed;
            if (Direction == 3) Y -= speed;
        }

        public void Render()
        {
            // Legacy OpenGL because I was too lazy to set up and generate shaders
            // Do not use this in a real game! It has been deprecated for a long time. Use shaders instead.
            GL.glColor3f(r, g, b);
            GL.glBegin(GL.GL_QUADS);
            GL.glVertex2d(X, Y);
            GL.glVertex2d(X + 32, Y);
            GL.glVertex2d(X + 32, Y + 32);
            GL.glVertex2d(X, Y + 32);
            GL.glEnd();
        }
    }
}
