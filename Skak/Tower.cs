using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Skak
{
    class Tower : Piece
    {
        public Tower(int position, bool isBlack)
        {
            IsBlack = isBlack;
            Type = ChessPieceTypes.Tower;
            TransformToRowAndColumn(position);
            Position = position;
            IsFirstMove = false;
        }
        public override int AvailableMoves(Rectangle rect)
        {
            throw new NotImplementedException();
        }
    }
}
