using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Skak
{
    public enum ChessPieceTypes
    {
        Pawn,
        Tower,
        Knight,
        Bishop,
        Queen,
        King,
    }
    abstract class Piece : INotifyPropertyChanged
    {
        private int row;
        public int Row
        {
            get { return row; }
            set
            {
                row = value;
                OnPropertyChanged("Row");
            }
        }
        private int col;
        public int Col
        {
            get { return col; }
            set
            {
                col = value;
                OnPropertyChanged("Col");
            }
        }
        public int Position { get; set; }
        public int Points { get; set; }
        public bool IsBlack { get; set; }
        public bool IsSelected { get; set; }
        public bool IsFirstMove { get; set; }
        public ChessPieceTypes Type { get; set; }
        public string ImageSource
        {
            get { return "ImagePieces/" + (IsBlack ? "Black" : "White") + Type.ToString() + ".png"; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void TransformToRowAndColumn(int position)
        {
            Row = position % 8 == 0 ? position / 8 - 1 : position / 8;

            Col = position % 8 == 0 ? 8 - 1 : position - Row * 8 - 1;
        }

        public void TakePiece(Rectangle rect, ObservableCollection<Piece> list)
        {

        }

        public bool IsPositionFree(Rectangle rect, ObservableCollection<Piece> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (int.Parse(rect.Uid) == list[i].Position && IsBlack != list[i].IsBlack)
                {
                    return false;
                }
            }
            return true;
        }

        public abstract int AvailableMoves(Rectangle rect);
    }
}
