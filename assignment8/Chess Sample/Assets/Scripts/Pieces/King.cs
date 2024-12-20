using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// King.cs
public class King : Piece
{
    public override MoveInfo[] GetMoves()
    {
        // --- TODO ---
        MoveInfo[] Result = new MoveInfo[8];
        int top = -1;
        for(int i = -1; i <= 1; i++){
            for(int j = -1; j <= 1; j++){
                if((i | j) != 0)
                    Result[++top] = new MoveInfo(i, j, 1);
            }
        }
        return Result;
        // ------
    }
}
