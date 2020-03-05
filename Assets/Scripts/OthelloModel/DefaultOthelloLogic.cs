using OthelloModel.Data;
namespace OthelloModel
{
    public class DefaultOthelloLogic : OthelloLogicBase
    {
        public DefaultOthelloLogic(Board board,PieceColorType startTurn) : base(board,startTurn)
        {
        }

        protected override void CheckEnd()
        {
            IsEnd = Board.IsFull();
        }

        protected override void RunReverse(CellPos putPos)
        {
            // TODO
        }
    }
}