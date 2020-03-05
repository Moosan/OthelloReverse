namespace OthelloModel
{
    public class CellPresenter
    {
        private readonly Cell cell;
        private readonly OthelloLogicBase othelloLogicBase;
        public bool HasPiece => cell.HasPiece;
        public CellPresenter(Cell cell,OthelloLogicBase othelloLogicBase)
        {
            this.cell = cell;
            this.othelloLogicBase = othelloLogicBase;
        }
        public bool TryPut()
        {
            if (!othelloLogicBase.CanPut(cell.Pos)) return false;
            othelloLogicBase.Put(cell.Pos);
            return true;
        }
    }
}