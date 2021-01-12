using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Skak
{
    class Bishop : Piece
    {
        public Bishop(int position, bool isBlack)
        {
            IsBlack = isBlack;
            Type = ChessPieceTypes.Bishop;
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
