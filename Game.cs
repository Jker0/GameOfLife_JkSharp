using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardCanvas_Jker0_Lib;

namespace GameOfLife_JkSh
{
    internal static class Game
    {
        public static void NextStep(BoardCanvas boardCanvas)
        {
            int CountNearCell = 0;
            int MaxY = boardCanvas.GetLength(0);
            int MaxX = boardCanvas.GetLength(1);
            for (int X = 0; X < MaxX; X++) 
                for (int Y = 0; Y < MaxY; Y++)
                {
                    CountNearCell = CountNearCells(X, Y, boardCanvas, MaxX, MaxY);
                    if (boardCanvas[Y, X] == 1 && (CountNearCell < 2 || CountNearCell > 3))
                        boardCanvas[Y, X] = 2;
                    else if (boardCanvas[Y, X] == 0 && CountNearCell == 3)
                        boardCanvas[Y, X] = 3;
                }

            boardCanvas.UpdateCanvas();
        }

        private static int CountNearCells(int row, int col, BoardCanvas boardCanvas, int MaxX, int MaxY)
        {
            int NearCell = 0;

            //UP - Left
            NearCell += CheckCell(row - 1, col - 1, boardCanvas, MaxX, MaxY);

            //UP
            NearCell += CheckCell(row, col - 1, boardCanvas, MaxX, MaxY);

            //UP - Right
            NearCell += CheckCell(row + 1, col - 1, boardCanvas, MaxX, MaxY);

            //Right
            NearCell += CheckCell(row + 1, col, boardCanvas, MaxX, MaxY);

            //Left 
            NearCell += CheckCell(row - 1, col, boardCanvas, MaxX, MaxY);

            //DOWN - Right
            NearCell += CheckCell(row + 1, col + 1, boardCanvas, MaxX, MaxY);

            //Down 
            NearCell += CheckCell(row, col + 1, boardCanvas, MaxX, MaxY);

            //Down - Left 
            NearCell += CheckCell(row - 1, col + 1, boardCanvas, MaxX, MaxY);

            return NearCell;

        }

        private static int CheckCell(int row, int col, BoardCanvas boardCanvas, int MaxX, int MaxY)
        {
            int countNearCell = 0;
            int UP = ItUP(col, MaxY);
            int Right = ItRight(row, MaxX);

            if (boardCanvas[UP, Right] == 1 || boardCanvas[UP, Right] == 2)
                countNearCell++;
            
            return countNearCell;
        }

        private static int ItUP(int Y, int MaxY)
        {
            int NewY = Y;
            if (Y < 0)
                NewY = MaxY - 1;
            else if (Y > MaxY - 1)
                NewY = 0;

            return NewY;
        }

        private static int ItRight(int X, int MaxX)
        {
            int NewX = X;
            if (X < 0)
                NewX = MaxX - 1;
            else if (X > MaxX - 1)
                NewX = 0;

            return NewX;
        }
    }
}
