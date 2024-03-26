using Raylib_cs;
using System.Numerics;

namespace Ship_Game
{
    internal class Program
    {
        static string title = "Ship Game";

        public static bool gameOver = false;

        static Asteroids[] asteroids;
        static int numAsteroidsSpawning = 5;
        static int asteroidCount = 0;
        static int maxNumAsteroids = 50;

        static void Main(string[] args)
        {
            Raylib.InitWindow(1620, 1080, title);
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

            for (int i = 0; i <= numAsteroidsSpawning; i++)
            {
                asteroids[i] = new Asteroids();
                asteroids[i].Random();
                asteroidCount++;
            }
        }
        static void Update()
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
