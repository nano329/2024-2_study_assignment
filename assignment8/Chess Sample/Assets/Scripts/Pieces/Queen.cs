using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Piece
{
    public override MoveInfo[] GetMoves()
    {
        // --- TODO ---
        MoveInfo[] Result = new MoveInfo[64];
        int top = -1;
        for(int i = 0; i <= 7; i++){
            for(int j = -1; j <= 1; j++){
                for(int k = -1; k <= 1; k++){
                    if ((k | j) != 0){
                        Result[++top] = new MoveInfo(j, k, i);
                    }
                }
            }
        }
        return Result;
        // ------
    }
}