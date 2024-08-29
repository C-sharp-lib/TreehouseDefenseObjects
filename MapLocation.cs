﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TreehouseDefense
{
    class MapLocation : Point 
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        { 
            if (!map.OnMap(this))
            {
                throw new Exception("(" + x + ", " + y + ") is outside the map zone.");
            }
        }
    }
}
