using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Maze
    {
        static char start_sign = 'S';//by default
        static char end_sign = 'E';//by default
        static char block_sign = '#';//by default
        private static Vertex start;
        private static Vertex end;

        //builds a maze
        public static int[,] Vertecies_name(char[,] mazeMatrix, char start_char, char end_char, char block_char)
        {
            block_sign = block_char;
            start_sign = start_char;
            end_sign = end_char;
            int raw = mazeMatrix.GetLength(0);
            int col = mazeMatrix.GetLength(1);
            int[,] NameOfvertex = new int[raw, col];
            int index = 0;
            for (int i = 0; i < raw; ++i)
                for (int j = 0; j < col; j++)
                {
                    if (mazeMatrix[i, j] != block_sign)
                        NameOfvertex[i, j] = index++;
                    else
                        NameOfvertex[i, j] = -1;
                    if (mazeMatrix[i, j] == start_sign)
                        start = new Vertex(NameOfvertex[i, j], i, j);
                    if (mazeMatrix[i, j] == end_sign)
                        end = new Vertex(NameOfvertex[i, j], i, j);

                }
            return NameOfvertex;
        }

        public static Vertex get_start_point()
        {
            return start;
        }

        public static Vertex get_end_point()
        {
            return end;
        }

        public static void printMaze(char[,] maze)
        {
            int row = maze.GetLength(0);
            int col = maze.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (maze[i, j] == ' ')
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


        /**
 * Randomizes a maze using random Prim's algorithm;
 */
        public static char[,] get_random_maze(int hight, int width, char start_char, char end_char, char block_char)
        {
            Prim.set_signs(start_char, end_char);
            start_sign = start_char; end_sign = end_char; block_sign = block_char;
            char[,] maze = new char[hight, width];
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    maze[i, j] = block_sign;
                }
            }
            int[,] graph = new int[hight, width];
            int index = 0;
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    graph[i, j] = index++;

                }
            }
            Graph G = new Graph(graph);
            Prim.primMaze(G, graph, maze);
            return maze;
        }
    }
}
