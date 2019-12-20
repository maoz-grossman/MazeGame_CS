using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Game
    {
        private class Player
        {
            public int i = 0;
            public int j = 0;
        }

        private static char[,] maze;
        private static Player player;
        private static bool running = true;
        private static char start_sign = 'S';//by default
        private static char end_sign = 'E';//by default
        private static char block_sign = '#';//by default

        public static void New_Game(char[,] _maze, char block)
        {
            block_sign = block;
            maze = _maze;
            player = new Player();
            while (running)
            {
                Console.Clear();
                printlogo();
                print();
                Console.WriteLine("\n you can shift the player by the arrowrs" +
                    "\n also you can see thee solution by pressing Enter");
                get_key();


                if (player.i == maze.GetLength(0) - 1 && player.j == maze.GetLength(1) - 1)
                {
                    Console.WriteLine("\n");
                    var arr = new[]
                    {
                        @"       $$  $$  $$  $$  $$    $$    $$   $$  $$$$$$$    ",
                        @"         $$   $  $ $$  $$    $$ $$ $$   $$  $$   $$    ",
                        @"         $$    $$    $$       $$  $$    $$  $$   $$    ",
                    };
                    foreach (string line in arr)
                        Console.WriteLine(line);
                    play_mario_theme();

                    print_solution();
                    break;
                }

            }
        }

        //---------------------//
        //    Print the logo   //
        //---------------------//

        public static void printlogo()
        {
            Console.WriteLine("\t\t\t\t ---the---");
            var arr = new[]
          {

@"       / $$$$$$/$$$$        / $$$$$$$      $$$$$$$$$$       / $$$$$$$$        ",
@"       | $$_   $$_  $$     | $$   |  $$   /______/ $        | $$_____/        ",
@"       | $$  \ $$ \ $$     | $$$$$$$$$$         / $         | $$$$$$$$        ",
@"       | $$  | $$ | $$     | $$    | $$        / $          | $$_____/        ",
@"       | $$  | $$ | $$     | $$    | $$       / $$$$$$$$$   | $$$$$$$$        ",
@"       |_/   |__/ |__/     |__/    |__/      |__________/   |________/        ",
            };

            //Console.WindowWidth = 80;
            Console.WindowHeight = 55;
            Console.WriteLine();
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.WriteLine("\n\n");
            //Console.ReadKey();
        }




        //-------------------------------//
        //    print the maze with color  //
        //-------------------------------//
        private static void print_board()
        {
            int row = maze.GetLength(0);
            int col = maze.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == player.i && j == player.j)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("☺ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (maze[i, j] == ' ')
                    {
                        Console.Write("  ");
                    }
                    else if (maze[i, j] == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(maze[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (maze[i, j] == start_sign || maze[i, j] == end_sign)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(maze[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(maze[i, j] + " ");
                    }

                }
                Console.WriteLine();

            }

        }

        //---------------------//
        // print without color //
        //---------------------//

        public static void print()
        {
            int row = maze.GetLength(0);
            int col = maze.GetLength(1);
            string game_window = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == player.i && j == player.j)
                    {   /*
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("☺ ");
                        Console.ForegroundColor = ConsoleColor.White;
                        */
                        game_window += "☺ ";
                    }
                    else if (maze[i, j] == ' ')
                    {
                        //Console.Write("  ");
                        game_window += "  ";
                    }
                    else if (maze[i, j] == '.')
                    {   /*
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(maze[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        */
                        game_window +=  maze[i, j] + " ";
                    }
                    else if (maze[i, j] == start_sign || maze[i, j] == end_sign)
                    {
                        /*
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(maze[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;*/
                        game_window += maze[i, j] + " ";
                    }
                    else
                    {
                        //Console.Write(maze[i, j] + " ");
                        game_window += maze[i, j] + " ";
                    }

                }
                //Console.WriteLine();
                game_window += "\n";
            }
            Console.WriteLine(game_window);
        } 



        //----------------------------//
        // get value from the console //
        //----------------------------//

        private static void get_key()
        {
            int sleep_time = 200;
            var ch = Console.ReadKey(false).Key;
            switch (ch)
            {
                case ConsoleKey.UpArrow:
                    set_player_movment(-1, 0);
                    Thread.Sleep(sleep_time);
                    return;
                case ConsoleKey.DownArrow:
                    set_player_movment(1, 0);
                    Thread.Sleep(sleep_time);
                    return;
                case ConsoleKey.RightArrow:
                    set_player_movment(0, 1);
                    Thread.Sleep(sleep_time);
                    return;
                case ConsoleKey.LeftArrow:
                    set_player_movment(0, -1);
                    Thread.Sleep(sleep_time);
                    return;
                case ConsoleKey.Enter:
                    print_solution();
                    return;
            }
        }

        //----------------------//
        //  set player i and j  //
        //----------------------//

        private static void set_player_movment(int _i, int _j)
        {
            int player_i = player.i + _i;
            int player_j = player.j + _j;
            if (player_i >= maze.GetLength(0) || player_i < 0)
            {
                Console.Beep(659, 125);
                return;
            }
            if (player_j >= maze.GetLength(1) || player_j < 0)
            {
                Console.Beep(659, 125);
                return;
            }
            if (maze[player_i, player_j] == block_sign)
            {
                Console.Beep(300, 100);
                return;
            }
            player.i = player_i;
            player.j = player_j;
        }


        //----------------------//
        //  print the solution  //
        //----------------------//
        private static void print_solution()
        {
            int[,] mazename = Maze.Vertecies_name(maze, 'S', 'E', '*');
            Graph g = new Graph(mazename);
            Vertex _s = Maze.get_start_point();
            BFS bfs = new BFS(g, _s);
            bfs.Get_path(Maze.get_end_point(), maze);
            Console.Clear();
            printlogo();
            Console.WriteLine("\n\t\t\t   ---solution---\n");
            Maze.printMaze(maze);
            Console.WriteLine();
            Console.ReadKey();
        }







        //---------------------------------------//
        // if you win it playes mario theme song //
        //---------------------------------------//

        private static void play_mario_theme()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125); Thread.Sleep(375);
            /*
            Console.Beep(523, 125); Thread.Sleep(250);
            Console.Beep(392, 125); Thread.Sleep(250);
            Console.Beep(330, 125); Thread.Sleep(250);
            Console.Beep(440, 125); Thread.Sleep(125);
            Console.Beep(494, 125); Thread.Sleep(125);
            Console.Beep(466, 125); Thread.Sleep(42);
            Console.Beep(440, 125); Thread.Sleep(125);
            Console.Beep(392, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(125);
            Console.Beep(784, 125); Thread.Sleep(125);
            Console.Beep(880, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(784, 125);
            Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(587, 125);
            Console.Beep(494, 125); Thread.Sleep(125);
            Console.Beep(523, 125); Thread.Sleep(250);
            Console.Beep(392, 125); Thread.Sleep(250);
            Console.Beep(330, 125); Thread.Sleep(250);
            Console.Beep(440, 125); Thread.Sleep(125);
            Console.Beep(494, 125); Thread.Sleep(125);
            Console.Beep(466, 125); Thread.Sleep(42);
            Console.Beep(440, 125); Thread.Sleep(125);
            Console.Beep(392, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(125);
            Console.Beep(784, 125); Thread.Sleep(125);
            Console.Beep(880, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(784, 125);
            Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(587, 125);
            Console.Beep(494, 125); Thread.Sleep(375);
            Console.Beep(784, 125); Console.Beep(740, 125);
            Console.Beep(698, 125); Thread.Sleep(42);
            Console.Beep(622, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167);
            Console.Beep(415, 125); Console.Beep(440, 125);
            Console.Beep(523, 125); Thread.Sleep(125);
            Console.Beep(440, 125); Console.Beep(523, 125);
            Console.Beep(587, 125); Thread.Sleep(250);
            Console.Beep(784, 125); Console.Beep(740, 125);
            Console.Beep(698, 125); Thread.Sleep(42);
            Console.Beep(622, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167);
            Console.Beep(698, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(698, 125);
            Thread.Sleep(625); Console.Beep(784, 125);
            Console.Beep(740, 125); Console.Beep(698, 125);
            Thread.Sleep(42); Console.Beep(622, 125);
            Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(167); Console.Beep(415, 125);
            Console.Beep(440, 125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125); Thread.Sleep(250);
            Console.Beep(622, 125); Thread.Sleep(250);
            Console.Beep(587, 125); Thread.Sleep(250);
            Console.Beep(523, 125); Thread.Sleep(1125);
            Console.Beep(784, 125); Console.Beep(740, 125);
            Console.Beep(698, 125); Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(167); Console.Beep(415, 125);
            Console.Beep(440, 125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125);
            Console.Beep(587, 125); Thread.Sleep(250);
            Console.Beep(784, 125); Console.Beep(740, 125);
            Console.Beep(698, 125); Thread.Sleep(42);
            Console.Beep(622, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167);
            Console.Beep(698, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(698, 125);
            Thread.Sleep(625); Console.Beep(784, 125);
            Console.Beep(740, 125); Console.Beep(698, 125);
            Thread.Sleep(42); Console.Beep(622, 125);
            Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(167); Console.Beep(415, 125);
            Console.Beep(440, 125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(440, 125);
            Console.Beep(523, 125); Console.Beep(587, 125);
            Thread.Sleep(250); Console.Beep(622, 125);
            Thread.Sleep(250); Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            */
        }

    }
}