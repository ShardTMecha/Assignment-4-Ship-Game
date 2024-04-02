using Raylib_cs;
using System.Numerics;

namespace ShipGame
{
    internal class Program
    {
        
        static string title = "Ship Game";

        static void Main(string[] args)
        {
            
            Raylib.InitWindow(1920, 1080, title);
           
            Raylib.SetTargetFPS(60);

            
            Setup();

            
            while (!Raylib.WindowShouldClose())
            {
                
                Raylib.BeginDrawing();
                
                Raylib.ClearBackground(Color.RayWhite);

                
                Update();

                
                Raylib.EndDrawing();
            }
            
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            
        }

        static void Update()
        {
            
        }
    }
}
