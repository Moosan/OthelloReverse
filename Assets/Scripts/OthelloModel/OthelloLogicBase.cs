using OthelloModel.Data;
namespace OthelloModel
{
    public abstract class OthelloLogicBase
    {
        public readonly Board Board;
        public PieceColorType Turn { get; protected set; }
        public bool IsEnd { get; protected set; }
        public OthelloLogicBase(Board board,PieceColorType startTurn)
        {
            Board = board;
            Turn = startTurn;
        }
        public virtual bool CanPut(CellPos pos)
        {
            return Board.HasPieceByPos(pos);
        }
        protected abstract void RunReverse(CellPos putPos);
        public virtual void Put(CellPos pos)
        {
            if (!CanPut(pos)) return;
            Board.Put(pos, Turn);
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