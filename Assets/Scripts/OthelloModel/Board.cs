using System.Collections;
using System.Collections.Generic;
using OthelloModel.Data;
namespace OthelloModel
{
    public class Board
    {
        public readonly Cell[][] Cells;
        public Board(Cell[][] cells)
        {
            Cells = cells;
        }
        public void Put(CellPos pos,PieceColorType color)
        {
            var cell = CellByPos(pos);
            if (HasPieceByPos(pos)) return;
            cell.Put(color);
        }
        public bool HasPieceByPos(CellPos pos)
        {
            return CellByPos(pos).HasPiece;
        }
        private Cell CellByPos(CellPos pos)
        {
            return Cells[pos.x][pos.y];
        }
        public bool IsFull()
        {
            foreach (var row in Cells)
            {
                foreach (var cell in row)
                {
                    if (!cell.HasPiece) return false;
                }
            }
            return true;
        }
        public interface IBoardFactory
        {
            Board Create();
        }
        public class DefaultBoardFactory : IBoardFactory
        {
            public const int CELL_COUNT = 8;

            public Board Create()
            {
                var cells = new Cell[CELL_COUNT][];
                for(int i = 0; i < CELL_COUNT; ++i)
                {
                    cells[i] = new Cell[CELL_COUNT];
                    for(int j = 0;j < CELL_COUNT; ++j)
                    {
                        cells[i][j] = new Cell(new CellPos(i,j));
                    }
                }
                cells[3][3].Put(PieceColorType.White);
                cells[3][4].Put(PieceColorType.Black);
                cells[4][3].Put(PieceColorType.Black);
                cells[4][4].Put(PieceColorType.White);
                return new Board(cells);
            }
        }
    }
}