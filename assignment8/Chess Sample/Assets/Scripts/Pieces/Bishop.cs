using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : Piece
{
    public override MoveInfo[] GetMoves()
    {
        // --- TODO ---
        MoveInfo[] Result = new MoveInfo[64];
        int top = -1;
        for(int i = 0; i <= 7; i++){
            Result[++top] = new MoveInfo(1, 1, i);
            Result[++top] = new MoveInfo(1, -1, i);
            Result[++top] = new MoveInfo(-1, 1, i);
            Result[++top] = new MoveInfo(-1, -1, i);
        }
        return Result;
        // ------
    }
}