using System;
using Raylib_cs;

namespace RayLibGFX
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(800, 600, "Pong");
            Color pastelPurple = new Color(240, 204, 255, 255);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(pastelPurple);
                Raylib.EndDrawing();
            }
        }
    }
}
