using Raylib_cs;
using System.Numerics;

namespace Ship_Game
{
    internal class Program
    {
       
        static string title = "Ship Game";

        static Random rng = new Random();

        public static bool gameOver = false;
        static int score = 0;
        static bool isAlive = true;
        static int frameCount = 0;

        static Asteroids[] asteroids;
        
        static int asteroidCount = 0;
        static int maxNumAsteroids = 500;//Amount of asteroids the array contains

        static void Main(string[] args)
        {
            Raylib.InitWindow(1920, 1100, title);
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
            

            asteroids = new Asteroids[maxNumAsteroids];

            for (int i = 0; i < asteroids.Length; i++)
            {
                asteroids[i] = new Asteroids(new Vector2(1920 + (200 * i), (rng.Next(0, 22) * 50)));               
                asteroidCount++;
            }
        }
        static void Update()
        {
            if (gameOver)
            {
                Raylib.DrawText("GAME OVER", 700, 550, 100, Color.Red);
            }
            else
            {
                Raylib.DrawText($"Score: {score}", Raylib.GetScreenWidth() - 150, 10, 20, Color.Black);
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
                //Draw and add movement to the spawing asteroids
                for (int i = 0; i < asteroidCount; i++)
            {
                asteroids[i].DrawAsteroids();
                asteroids[i].Movement();
            }
        }
       

           
        }



    }
}
