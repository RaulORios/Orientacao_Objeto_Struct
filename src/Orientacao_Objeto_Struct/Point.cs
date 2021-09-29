using System;
using System.Collections.Generic;
using System.Text;

namespace Orientacao_Objeto_Struct
{
    struct Point
    {
        public double x;
        public double y;


        public override string ToString()
        {
            return ($"({x}, {y})");
        }

    }
}
