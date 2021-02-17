using System;
using Raylib_cs;

namespace raylib_new
{
    class Program
    {

        int wWidth = 800;
        int wHeight = 450;
        string wTitle = "Game State Managment";
        static void Main(string[] args)
        {
            Program p = new Program();
            p.RunGame();
        }

        void RunGame()
        {
            Raylib.InitWindow(wWidth , wHeight , wTitle);
            Raylib.SetTargetFPS(60);

            LoadGame();
            while (!Raylib.WindowShouldClose())
            {
                Update();
                Draw();
            }
        }
        void LoadGame()
        {

        }
        void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.RAYWHITE);

            Raylib.DrawFPS(10 , wHeight - 20);
            Raylib.EndDrawing();
        }
        void Update()
        {

        }
    }
}
