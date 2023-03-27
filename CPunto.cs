using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaConsola
{
    internal class CPunto
    {
        private int X;
        private int Y;


        //Constructor
        public CPunto(int px, int py)
        {
            X = px;
            Y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", X,Y);
        }
    }
}
