using Raylib_cs;
using System.Numerics;

namespace ExampleProject
{
    internal class Program
    {
       
        static string title = "Ship Game";
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

                // Draw the score
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
            //Defining the duration
            const int framesPer1Second = 100;

            if (isAlive)
            {
               
               
                frameCount++;

               //Framecount reaches specified duration then score increases
                if (frameCount >= framesPer1Second)
                {
                    //Increases score
                    score++;
                    //Resets frame count
                    frameCount = 0;
                }
            }
        }
    }
}
