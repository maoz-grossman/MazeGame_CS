using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Graph
    {
        //  a dinamic list of neighbos
        public List<LinkedList<Vertex>> Adj;
        public Graph(int[,] graph)
        {
            Adj = new List<LinkedList<Vertex>>();
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] >= 0)
                    {
                        LinkedList<Vertex> list = new LinkedList<Vertex>();
                        Vertex v = new Vertex(graph[i, j], i, j);
                        list.AddFirst(v);
                        getNeighbors(list, graph, v, i, j, 1);
                        Adj.Add(list);
                    }
                }

            }
        }

        private void getNeighbors(LinkedList<Vertex> list, int[,] graph, Vertex pre, int i, int j, int skip)
        {
            try
            {
                if (graph[i - skip, j] >= 0)
                {
                    Vertex v = new Vertex(graph[i - skip, j], i - skip, j);
                    v.pre = pre;
                    list.AddLast(v);
                }

            }
            catch (Exception e)
            {

            }
            try
            {
                if (graph[i + skip, j] >= 0)
                {
                    Vertex v = new Vertex(graph[i + skip, j], i + skip, j);
                    v.pre = pre;
                    list.AddLast(v);
                }
            }
            catch (Exception e)
            {

            }
            try
            {
                if (graph[i, j - skip] >= 0)
                {
                    Vertex v = new Vertex(graph[i, j - skip], i, j - skip);
                    v.pre = pre;
                    list.AddLast(v);
                }
            }
            catch (Exception e)
            {

            }
            try
            {
                if (graph[i, j + skip] >= 0)
                {
                    Vertex v = new Vertex(graph[i, j + skip], i, j + skip);
                    v.pre = pre;
                    list.AddLast(v);
                }
            }
            catch (Exception e)
            {

            }

        }

        public override string ToString()
        {
            string s = "";
            foreach (LinkedList<Vertex> list in Adj)
            {
                foreach (Vertex v in list)
                {
                    s += v.name + "-> ";
                }
                s += "\n";
            }
            return s;
        }






    }
}
