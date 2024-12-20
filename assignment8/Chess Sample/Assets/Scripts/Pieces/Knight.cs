using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Knight.cs
public class Knight : Piece
{
    public override MoveInfo[] GetMoves()
    {
        // --- TODO ---
        MoveInfo[] Result = new MoveInfo[8];
        int top = -1;
        for(int i = -2; i <= 2; i++){
            for(int j = -2; j <= 2; j++){
                if((i + j) * (i + j) == 9 || (i - j) * (i - j) == 9)
                    Result[++top] = new MoveInfo(i, j, 1);
            }
        }
        return Result;
        // ------
    }
}