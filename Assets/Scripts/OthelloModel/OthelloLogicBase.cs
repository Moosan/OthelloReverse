using System.Collections;
using System.Collections.Generic;
using OthelloModel.Data;
namespace OthelloModel
{
    public abstract class OthelloLogicBase
    {
        public readonly Board Board;
        public PieceColorType Turn { get; protected set; }
        public bool IsEnd { get; protected set; }
        public OthelloLogicBase(Board board)
        {
            Board = board;
        }
        public virtual bool CanPut(CellPos pos,PieceColorType color)
        {
            return Board.HasPieceByPos(pos);
        }
        protected abstract void RunReverse(CellPos putPos);
        public virtual void Put(CellPos pos,PieceColorType color)
        {
            if (!CanPut(pos, color)) return;
            Board.Put(pos, color);
            RunReverse(pos);
            CheckEnd();
            ChangeTurn();
        }
        protected virtual void ChangeTurn()
        {
            Turn = Turn == PieceColorType.White ? PieceColorType.Black : PieceColorType.White;
        }
        protected abstract void CheckEnd();
    }
}