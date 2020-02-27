using System;
using OthelloModel.Data;
namespace OthelloModel
{
    public class Cell
    {
        public Piece piece;
        public readonly CellPos Pos;
        public bool HasPiece { get { return piece != null; } }
        public Cell(CellPos pos)
        {
            Pos = pos;
        }
        public void Put(PieceColorType color)
        {
            if (HasPiece)
            {
                //置くときは置けるか確認する
                // TODO 置けたかどうかのリザルトを返すようにする
                throw new Exception("置けないよ");
            }
            piece = new Piece(color);
        }
        public void Reverse()
        {
            if (!HasPiece) return;
            piece.Reverse();
        }
    }
}