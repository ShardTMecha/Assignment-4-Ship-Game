using Raylib_cs;
using System.Numerics;

namespace Ship_Game
{
    internal class Program
    {
        static string title = "Ship Game";

        static Random rng = new Random();
        public static bool gameOver = false;


        static Asteroids[] asteroids;
        
        static int asteroidCount = 0;
        static int maxNumAsteroids = 50;

        static void Main(string[] args)
        {
            Raylib.InitWindow(1620, 1100, title);
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
                Raylib.DrawText("GAME OVER", 810, 550, 100, Color.Red);
            }
            else
            {
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
