using OthelloModel.Data;
namespace OthelloModel
{
    public class DefaultOthelloLogic : OthelloLogicBase
    {
        public DefaultOthelloLogic(Board board) : base(board)
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