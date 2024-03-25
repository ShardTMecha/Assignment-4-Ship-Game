using Raylib_cs;
using System.Numerics;

namespace ExampleProject
{
    internal class Program
    {
       
        static string title = "Space idk";
        static int score = 0;
        static bool isAlive = true;
        static int frameCount = 0;

        static void Main(string[] args)
        {
            
            Raylib.InitWindow(800, 600, title);
            // to set the target frames-per-second 
            Raylib.SetTargetFPS(60);

           
            Setup();

            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
               
                Raylib.BeginDrawing();
               
                Raylib.ClearBackground(Color.Black);

               
                Update();

                // score
                Raylib.DrawText($"Score: {score}", Raylib.GetScreenWidth() - 150, 10, 20, Color.White);

               
                Raylib.EndDrawing();
            }
            
            Raylib.CloseWindow();
        }

        static void Setup()
        {
           
        }

        static void Update()
        {
            const int framesPer5Seconds = 100;

            if (isAlive)
            {
               
               
                frameCount++;

               
                if (frameCount >= framesPer5Seconds)
                {
                    score++;
                    frameCount = 0;
                }
            }
        }
    }
}
