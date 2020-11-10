using System.Collections.Generic;
using System.Drawing;
using System;
using Raylib_cs;

namespace RayLibGFX
{
    public class Rectangle
    {
        public static List<Paddle> paddles = new List<Paddle>();
        
        public Rectangle rect = new Rectangle();

        public KeyboarKey upKey;
        public KeyboarKey downKey;

        public Rectangle(float x, float y, KeyboarKey upKey, KeyboarKey downKey)
        {
            
        }
    }
}
