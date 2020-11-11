using System.Security.AccessControl;
using System;
using System.Collection.Generic;

namespace RayLibGFX
{
    public class Paddle
    {
        public static List<Paddle> paddles = new List<Paddle>();
        
        public Rectangle rect = new Rectangle();

        public KeyboarKey upKey;
        public KeyboarKey downKey;

        public Paddle(float xStart, float yStart, KeyboarKey up, KeyboarKey down)
        {
            x = xStart;
            y = yStart;

            upKey = up;
            downKey = down;
            
            paddles.Add(this);
        }

        public void Update(){
            
        }
    }
}
