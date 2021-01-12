using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Skak
{
    class Board
    {
        public Rectangle square;
        public List<Rectangle> DrawBoard()
        {
            var result = new List<Rectangle>();
            for (int i = 0; i < 8; i++)
            {
                bool isBlack = i % 2 == 1;
                for (int y = 0; y < 8; y++)
                {
                    square = new Rectangle { Fill = isBlack ? Brushes.Black : Brushes.White };
                    square.Uid = (y + 8 * i).ToString();
                    result.Add(square);
                    isBlack = !isBlack;
                }
            }
            return result;
        }
    }
}
