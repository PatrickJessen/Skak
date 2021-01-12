using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Skak
{
    class Pawn: Piece
    {
        public Pawn(int position, bool isBlack)
        {
            IsBlack = isBlack;
            Type = ChessPieceTypes.Pawn;
            TransformToRowAndColumn(position);
            Position = position;
            IsFirstMove = false;
        }

        public override int AvailableMoves(Rectangle rect)
        {
            if (Type == ChessPieceTypes.Pawn)
            {
                CheckIfWhite(rect);
                CheckIfBlack(rect);
            }
            return Position;
        }

        private int CheckIfWhite(Rectangle rect)
        {
            if (int.Parse(rect.Uid) > Position - 18 && int.Parse(rect.Uid) < Position - 16 && IsFirstMove == false && IsBlack == false || int.Parse(rect.Uid) > Position - 10 && int.Parse(rect.Uid) < Position - 8 && int.Parse(rect.Uid) > Position - 11 && IsFirstMove == false && IsBlack == false)
            {
                IsFirstMove = true;
                Position = int.Parse(rect.Uid) + 1;
                return Position;
            }
            else if (int.Parse(rect.Uid) > Position - 10 && int.Parse(rect.Uid) < Position - 8 && int.Parse(rect.Uid) > Position - 11 && IsFirstMove == true && IsBlack == false)
            {
                Position = int.Parse(rect.Uid) + 1;
                return Position;
            }
            return Position;
        }

        private int CheckIfBlack(Rectangle rect)
        {
            if (IsBlack == true && int.Parse(rect.Uid) < Position + 18 && int.Parse(rect.Uid) == Position + 15 && IsFirstMove == false || int.Parse(rect.Uid) < Position + 10 && int.Parse(rect.Uid) == Position + 7 && int.Parse(rect.Uid) < Position + 11 && IsFirstMove == false && IsBlack == true)
            {

                IsFirstMove = true;
                Position = int.Parse(rect.Uid) + 1;
                return Position;
            }
            else if (int.Parse(rect.Uid) < Position + 10 && int.Parse(rect.Uid) == Position + 7 && int.Parse(rect.Uid) < Position + 11 && IsFirstMove == true && IsBlack == true)
            {
                Position = int.Parse(rect.Uid) + 1;
                return Position;
            }
            return Position;
        }
    }
}
