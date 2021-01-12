using OxyPlot;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Skak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Piece piece;
        Board board = new Board();
        Image clicked;
        ObservableCollection<Piece> pieces { get; set; }
        //Piece pawn = new Pawn();
        public MainWindow()
        {
            pieces = new ObservableCollection<Piece>();
            InitializeComponent();
            PrintBoard();
            DataContext = pieces;
            NewGame();
        }

        private void PrintBoard()
        {
            for (int i = 0; i < board.DrawBoard().Count; i++)
            {
                SquaresGrid.Children.Add(board.DrawBoard()[i]);
            }
        }

        private void SquareMouseDown(object sender, RoutedEventArgs e)
        {
            Rectangle RectClicked = (Rectangle)e.OriginalSource;
            //MovePiece(int.Parse(clicked.Uid));
            //board.MoveFigure(int.Parse(clicked.Uid), 5);
            if (test == true && piece.IsPositionFree(RectClicked, pieces))
            {
                TransformToRowAndColumn(piece.AvailableMoves(RectClicked));
                //piece.Position = int.Parse(RectClicked.Uid) + 1;
                Debug.WriteLine(RectClicked.Uid);
                test = false;
            }
        }
        //Pawn pawn = new Pawn();
        bool test;
        private void OnMouseDown(object sender, RoutedEventArgs e)
        {
            clicked = (Image)e.OriginalSource;
            piece = (Piece)clicked.DataContext;
            Debug.WriteLine(piece.IsFirstMove.ToString());
            //TransformToRowAndColumn(pawn.testing(piece));
            //pawn.testing(piece);
            //if (board.square.Uid == piece.Position.ToString())
            //{
            //}
            test = true;
        }

        private void TransformToRowAndColumn(int position)
        {
            piece.Row = position % 8 == 0 ? position / 8 - 1 : position / 8;

            piece.Col = position % 8 == 0 ? 8 - 1 : position - piece.Row * 8 - 1;
        }

        public void NewGame()
        {
            //pieces.Clear();

            pieces.Add(piece = new Tower(1, true));
            pieces.Add(piece = new Knight(2, true));
            pieces.Add(piece = new Bishop(3, true));
            pieces.Add(piece = new Queen(4, true));
            pieces.Add(piece = new King(5, true));
            pieces.Add(piece = new Bishop(6, true));
            pieces.Add(piece = new Knight(7, true));
            pieces.Add(piece = new Tower(8, true));
            pieces.Add(piece = new Pawn(9, true));
            pieces.Add(piece = new Pawn(10, true));
            pieces.Add(piece = new Pawn(11, true));
            pieces.Add(piece = new Pawn(12, true));
            pieces.Add(piece = new Pawn(13, true));
            pieces.Add(piece = new Pawn(14, true));
            pieces.Add(piece = new Pawn(15, true));
            pieces.Add(piece = new Pawn(16, true));


            pieces.Add(piece = new Tower(57, false));
            pieces.Add(piece = new Knight(58, false));
            pieces.Add(piece = new Bishop(59, false));
            pieces.Add(piece = new Queen(60, false));
            pieces.Add(piece = new King(61, false));
            pieces.Add(piece = new Bishop(62, false));
            pieces.Add(piece = new Knight(63, false));
            pieces.Add(piece = new Tower(64, false));
            pieces.Add(piece = new Pawn(49, false));
            pieces.Add(piece = new Pawn(50, false));
            pieces.Add(piece = new Pawn(51, false));
            pieces.Add(piece = new Pawn(52, false));
            pieces.Add(piece = new Pawn(53, false));
            pieces.Add(piece = new Pawn(54, false));
            pieces.Add(piece = new Pawn(55, false));
            pieces.Add(piece = new Pawn(56, false));


            //pieces.Add(new Piece(1, true, ChessPieceTypes.Tower));
            //pieces.Add(new Piece(2, true, ChessPieceTypes.Knight));
            //pieces.Add(new Piece(3, true, ChessPieceTypes.Bishop));
            //pieces.Add(new Piece(4, true, ChessPieceTypes.Queen));
            //pieces.Add(new Piece(5, true, ChessPieceTypes.King));
            //pieces.Add(new Piece(6, true, ChessPieceTypes.Bishop));
            //pieces.Add(new Piece(7, true, ChessPieceTypes.Knight));
            //pieces.Add(new Piece(8, true, ChessPieceTypes.Tower));
            //pieces.Add(new Piece(9, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(10, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(11, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(12, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(13, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(14, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(15, true, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(16, true, ChessPieceTypes.Pawn));


            //pieces.Add(new Piece(57, false, ChessPieceTypes.Tower));
            //pieces.Add(new Piece(58, false, ChessPieceTypes.Knight));
            //pieces.Add(new Piece(59, false, ChessPieceTypes.Bishop));
            //pieces.Add(new Piece(60, false, ChessPieceTypes.Queen));
            //pieces.Add(new Piece(61, false, ChessPieceTypes.King));
            //pieces.Add(new Piece(62, false, ChessPieceTypes.Bishop));
            //pieces.Add(new Piece(63, false, ChessPieceTypes.Knight));
            //pieces.Add(new Piece(64, false, ChessPieceTypes.Tower));
            //pieces.Add(new Piece(49, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(50, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(51, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(52, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(53, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(54, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(55, false, ChessPieceTypes.Pawn));
            //pieces.Add(new Piece(56, false, ChessPieceTypes.Pawn));


        }
    }
}
