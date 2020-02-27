using OthelloModel.Data;
namespace OthelloModel
{
    public class Piece
    {
        public PieceColorType PieceColor { get; private set; } = PieceColorType.White;
        public Piece(PieceColorType pieceColorType)
        {
            PieceColor = pieceColorType;
        }
        public void Reverse()
        {
            PieceColor = PieceColor == PieceColorType.White ? PieceColorType.Black : PieceColorType.White;
        }
    }
}