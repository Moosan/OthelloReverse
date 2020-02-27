using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OthelloModel.Data
{
    public struct CellPos
    {
        public readonly int x;
        public readonly int y;
        public CellPos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}