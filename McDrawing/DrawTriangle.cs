using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace McDrawing
{
    class DrawTriangle
    {
        public int x;
        public int y;
        public int sideLength;
        public Color color;
        public DrawTriangle(int x, int y, int sideLength, string color)
        {
            int a = sideLength;
            if (sideLength % 2 != 0)
            {
                sideLength++;
            }
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    McRectangle buildingBlock = new McRectangle(x + i * 10, x + j * 10, 15, 15, color);
                }
                a--;
            }

        }

        public void changeColor(string color)
        {
            this.color = McDrawing.ParseColorString("blue");
        }
    }
}
