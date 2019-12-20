using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        public static void ThreadTesting()
        {
            ConsoleApp2.Mortal_combat mc = new ConsoleApp2.Mortal_combat();
            Thread thread= new Thread(new ThreadStart(mc.firstSection));
            thread.Start();
        }
        static void Main(string[] args)
        {
            /*

            var arr = new[]
            {

@"       / $$$$$$/$$$$        / $$$$$$$      $$$$$$$$$$       / $$$$$$$$        ",
@"       | $$_   $$_  $$     | $$   |  $$   /______/ $        | $$_____/        ",
@"       | $$  \ $$ \ $$     | $$$$$$$$$$         / $         | $$$$$$$$        ",
@"       | $$  | $$ | $$     | $$    | $$        / $          | $$_____/        ",
@"       | $$  | $$ | $$     | $$    | $$       / $$$$$$$$$   | $$$$$$$$        ",
@"       |_/   |__/ |__/     |__/    |__/      |__________/   |________/        ",
            };

            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.ReadKey();
            */
            //Game.printlogo();
            // Console.WriteLine("\n\n");


            //---------------//
            //   second try  //
            //---------------//

            //ThreadTesting();
            char[,] maze = Maze.get_random_maze(35, 35, 'S', 'E', '*');
            //Maze.printMaze(maze);
            Game.New_Game(maze, '*');
            //solution
            /*
            int[,] mazename = Maze.Vertecies_name(maze, 'S', 'E', '*');
            Graph g = new Graph(mazename);
            Vertex _s = Maze.get_start_point();
            BFS bfs = new BFS(g, _s);
            bfs.Get_path(Maze.get_end_point(), maze);
            Console.WriteLine("\n\t\t---solution---\n");
            Maze.printMaze(maze);
            Console.WriteLine();
           */






            //----------------//
            //    first try   //
            //----------------//

            /*
              char Block = '*';
              char Start = 'S';
              char End = 'E';
              char[,] maze = {{Block,Block,Block,Block,Block,Block,Block,Block,Block,Start,Block,Block,Block},
                     {Block,' ',Block,' ',' ',' ',Block,' ',' ',' ',' ',' ',Block},
                     {Block,' ',' ',' ',Block,Block,Block,' ',Block,Block,Block,' ',Block},
                     {Block,Block,Block,' ',Block,' ',Block,' ',Block,' ',Block,' ',Block},
                     {Block,' ',Block,' ',Block,' ',' ',' ',' ',' ',Block,' ',Block},
                     {Block,' ',Block,' ',Block,Block,Block,Block,Block,' ',Block,Block,Block},
                     {Block,' ',' ',Block,' ',Block,' ',' ',' ',' ',' ',' ',Block},
                     {Block,Block,' ',' ',' ',' ',Block,' ',Block,' ',Block,Block,Block},
                     {Block,Block,Block,Block,Block,' ',Block,' ',Block,' ',' ',' ',Block},
                     {Block,Block,' ',' ',' ',' ',' ',' ',Block,Block,Block,' ',Block},
                     {Block,' ',' ',Block,Block,' ',' ',Block,Block,' ',Block,' ',Block},
                     {Block,' ',' ',Block,' ',' ',' ',' ',Block,' ',' ',' ',Block},
                     {Block,Block,End,Block,Block,Block,Block,Block,Block,Block,Block,Block,Block}
                     };
              Maze.printMaze(maze);


              int[,] mazename = Maze.Vertecies_name(maze, Start, End, Block);

              Graph g = new Graph(mazename);

              Vertex _s = Maze.get_start_point();
              BFS bfs = new BFS(g, _s);
              bfs.Get_path(Maze.get_end_point(), maze);
             Console.WriteLine("\n    ---solution---\n");
              Maze.printMaze(maze);
              Console.WriteLine();
              */
        }
    }
}
