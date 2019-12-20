/**
*___________________________________________________________________________            	
*               		Randomized Prim's algorithm
* --------------------------------------------------------------------------
*  This algorithm is a randomized version of Prim's algorithm.
*  1. Start with a grid full of walls.
*  2. Pick a cell, mark it as part of the maze. 
*     Add the walls of the cell to the wall list.
*  3. While there are walls in the list:
*  	i) Pick a random wall from the list.
*  	   If only one of the two cells that the wall divides is visited, then:
*  		   a) Make the wall a passage and mark the unvisited cell 
*  			  as part of the maze.
*  		   b) Add the neighboring walls of the cell to the wall list.
*  	ii) Remove the wall from the list.
*   
* ----------------------------------------------------------------------------  	      
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Prim
    {

        //--------------------//
        //     global var     //
        //--------------------//

        private static char start_sign = 'S';
        private static char end_sign = 'E';
        private static bool[] of_the_maze;
        private static List<Vertex> Q = new List<Vertex>();
        private static int[,] graph;

        //-------------------//
        //     functions     // 
        //-------------------//

        public static void set_signs(char start, char end)
        {
            start_sign = start;
            end_sign = end;
        }


        public static void primMaze(Graph G, int[,] _graph, char[,] maze)
        {

            int number_of_verticies = G.Adj.Count;
            /**
		      * 2. Pick a cell, mark it as part of the maze. 
		      *     Add the walls of the cell to the wall list.
		      */
            LinkedList<Vertex> list = G.Adj[0];
            Vertex S = list.First.Value;
            graph = _graph;
            of_the_maze = new bool[number_of_verticies];
            //marks the source vertex as part of the maze
            of_the_maze[S.name] = true;
            Q = new List<Vertex>();

            //Adds all walls of S to the list
            foreach (Vertex v in list)
            {
                if (v.name != S.name)
                    Q.Add(v);
            }


            //3. While there are walls in the list:
            while (Q.Count != 0)
            {
                // i) Pick a random wall from the list.
                int num_of_walls = Q.Count;
                Random rnd1 = new Random();

                int random = rnd1.Next(num_of_walls);
                Random rnd = new Random(random);
                random = rnd.Next(random);
                random = rnd.Next(num_of_walls);
                Vertex u = Q[random];
                //If only one of the two cells that the wall divides is visited
                if (one_of_the_cells_is_visited(u))
                {
                    //a) Make the wall a passage
                    of_the_maze[u.name] = true;
                    int neighbor_index = get_neighbor(u);
                    Vertex neighbor = G.Adj[neighbor_index].First.Value;
                    //mark the unvisited cell  as part of the maze.
                    of_the_maze[neighbor_index] = true;
                    of_the_maze[u.pre.name] = true;
                    //b) Add the neighboring walls of the cell to the wall list.
                    foreach (Vertex v in G.Adj[neighbor.name])
                    {
                        if (v.name != S.name
                            &&
                      !of_the_maze[v.name])
                        {
                            Q.Add(v);
                        }

                    }
                }
                //ii) Remove the wall from the list.
                Q.Remove(u);
            }

            int maze_row = maze.GetLength(0);
            int maze_col = maze.GetLength(1);
            for (int i = 0; i < maze_row; i++)
            {
                for (int j = 0; j < maze_col; j++)
                {
                    if (i == 0 && j == 0)
                        maze[i, j] = start_sign;
                    else if (of_the_maze[graph[i, j]])
                        maze[i, j] = ' ';
                }
            }
            int end_point = graph[graph.GetLength(0) - 1, graph.GetLength(1) - 1];
            for (int i = of_the_maze.Length - 1; i > 0; --i)
            {
                if (of_the_maze[i] == true)
                {
                    end_point = i;
                    break;
                }
            }
            Vertex end = G.Adj[end_point].First.Value;
            maze[end.i, end.j] = end_sign;
        }
        private static int get_neighbor(Vertex v)
        {
            Vertex pre = v.pre;
            int _i;
            int _j;
            int neighbor = 0;
            if (v.i == pre.i)
            {
                _i = v.i;
            }
            else
                _i = (v.i - pre.i) + v.i;
            if (v.j == pre.j)
            {
                _j = v.j;
            }
            else
                _j = (v.j - pre.j) + v.j;
            try
            {
                neighbor = graph[_i, _j];
            }
            catch (Exception e)
            {
                return -1;
            }
            return neighbor;
        }

        //checks if one of the cells that the wall blocks is already part of the maze
        private static bool one_of_the_cells_is_visited(Vertex v)
        {
            Vertex pre = v.pre;
            int neighbor = get_neighbor(v);
            if (neighbor == -1)
                return false;
            if (of_the_maze[neighbor] && !of_the_maze[pre.name]
                    ||
              !of_the_maze[neighbor] && of_the_maze[pre.name])
                return true;

            return false;
        }

    }
}
