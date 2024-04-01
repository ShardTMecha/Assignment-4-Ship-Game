using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Game
{
    internal class Ship
    {
        static void Main(string[] args)
        {
            const int screenWidth = 1600;
            const int screenHeight = 1080;
            const int fps = 60;
            const float playerSpeed = 10.0f;

            Raylib.InitWindow(screenWidth, screenHeight, "Side Asteroid Game");
            Raylib.SetTargetFPS(fps);

            // Player variables
            Vector2 playerPosition = new Vector2(50, screenHeight / 2);
            float playerRadius = 20.0f;
            Color playerColor = Color.Red;

            while (!Raylib.WindowShouldClose())
            {
                // Update
                if (Raylib.IsKeyDown(KeyboardKey.W))
                {
                    // Move player up
                    playerPosition.Y -= playerSpeed;
                }
                else if (Raylib.IsKeyDown(KeyboardKey.S))
                {
                    // Move player down
                    playerPosition.Y += playerSpeed;
                }

                // Make sure player stays within bounds
                if (playerPosition.Y < playerRadius)
                {
                    playerPosition.Y = playerRadius;
                }
                else if (playerPosition.Y > screenHeight - playerRadius)
                {
                    playerPosition.Y = screenHeight - playerRadius;
                }

                // Draw
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);

                // Draw player
                Raylib.DrawCircleV(playerPosition, playerRadius, playerColor);

                Raylib.EndDrawing();

            }
        }
    }
}
