﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vertex
    {
        public int name;
        public int i;
        public int j;
        public Vertex pre;
        public Vertex(int _name, int _i, int _j)
        {
            name = _name;
            i = _i;
            j = _j;
        }
    }
}
