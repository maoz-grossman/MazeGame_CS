//-------------------------------------------------------------//
//*************************************************************//
//                  Breadth-first search                       //   
//____________________________________________________________ //
// Breadth-first search (BFS) is an algorithm for traversing   //
// or searching tree or graph data structures.                 //
// It starts at the tree root (or some arbitrary node of       // 
// a graph, sometimes referred to as a 'search key'[1]),       //
// and explores all of the neighbor nodes at the present depth // 
// prior to moving on to the nodes at the next depth level.    //
//*************************************************************//
//-------------------------------------------------------------//


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BFS
    {
        //---------------------//
        //      global var     //
        //---------------------//
        const int infinity = int.MaxValue;
        private string[] color;
        private Vertex[] parent;
        private int[] dist;
        private Queue<Vertex> Q;
        private Vertex source;



        public BFS(Graph G, Vertex _s)
        {
            int n = G.Adj.Count;
            color = new String[n];
            parent = new Vertex[n];
            dist = new int[n];
            for (int i = 0; i < n; i++)
            {
                color[i] = "WHIT";
                dist[i] = infinity;
                parent[i] = null;
            }
            Q = new Queue<Vertex>();
            source = _s;
            color[source.name] = "GRAY";
            dist[source.name] = 0;
            parent[source.name] = null;
            Q.Enqueue(source);
            initiate(G);
        }


        //-------------------//
        //   building tree   //
        //-------------------//

        private void initiate(Graph G)
        {
            while (Q.Count != 0)
            {
                Vertex u = Q.Dequeue();
                foreach (Vertex v in G.Adj[u.name])
                {
                    if (color[v.name].Equals("WHIT"))
                    {
                        color[v.name] = "GRAY";
                        dist[v.name] = dist[u.name] + 1;
                        parent[v.name] = u;
                        Q.Enqueue(v);
                    }
                }
                color[u.name] = "BLACK";
            }

        }


        //---------------------------------------------//
        //  Get the shortest path to a specific vertex //
        //---------------------------------------------//


        public string Get_path(Vertex v, char[,] maze)
        {
            char path_sign = '.';
            string path = "";
            Vertex par = parent[v.name];
            if (par == null) return "No path from source to v";
            path += par.name + "->" + v.name;
            maze[par.i, par.j] = path_sign;
            while (source.name != par.name)
            {
                par = parent[par.name];
                path = par.name + "->" + path;
                maze[par.i, par.j] = path_sign;
            }
            return path;
        }
    }
}
