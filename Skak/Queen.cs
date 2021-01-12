using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Skak
{
    class Queen : Piece
    {
        public Queen(int position, bool isBlack)
        {
            IsBlack = isBlack;
            Type = ChessPieceTypes.Queen;
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
