using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLinePiece : ClearablePiece
{
    public bool isRow;
    
    public override void Clear()
    {
        base.Clear();

        if (isRow)
        {
            //Clear Row
            piece.GridRef.ClearRow(piece.Y);
        }
        else
        {
            //Clear Column
            piece.GridRef.ClearCol(piece.X);
        }
    }
}
