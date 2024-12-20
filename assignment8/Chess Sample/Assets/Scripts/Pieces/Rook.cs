using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rook.cs
public class Rook : Piece
{
    public override MoveInfo[] GetMoves()
    {
        // --- TODO ---
        MoveInfo[] Result = new MoveInfo[64];
        int top = -1;
        for(int i = 0; i <= 7; i++){
            Result[++top] = new MoveInfo(1, 0, i);
            Result[++top] = new MoveInfo(0, 1, i);
            Result[++top] = new MoveInfo(-1, 0, i);
            Result[++top] = new MoveInfo(0, -1, i);
        }
        return Result;
        // ------
    }
}
