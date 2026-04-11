using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program
{
    public class Motor
    {
        public Board NextGeneration(Board currentBoard)
        {
            Board nextBoard = new Board(currentBoard.BoardHeight, currentBoard.BoardWidth);

            for (int x = 0; x < currentBoard.BoardWidth; x++)
            {
                for(int y = 0; y < currentBoard.BoardHeight; y++ ){
                    int aliveNeighbors = this.CountAliveNeighbors(currentBoard, x, y);
                    bool isAlive = currentBoard.getCell(x, y);

                    if (isAlive && (aliveNeighbors < 2 || aliveNeighbors > 3))
                    {
                        //muere por soledad o por sobrepoblación
                        nextBoard.SetCell(x, y, false);
                    }
                    else if (!isAlive && aliveNeighbors == 3)
                    {
                        //nace por reproducción

                        nextBoard.SetCell(x, y, true);
                    }
                    else
                    {   
                        //mantiene su estado
                        nextBoard.SetCell(x, y, isAlive);
                    }
                }
            }
            return nextBoard;
        }
        //cuenta los vecinos vivos alrededor de la celda en (x, y)
        private int CountAliveNeighbors(Board board, int x, int y)
        {
            int aliveNeighbors = 0;
            for (int i = x -1; i <= x; i++)
            {
                for (int j = y - 1; j <= y; j++)
                {
                    // Valida que la posición (i, j) esté dentro de los límites del tablero
                    if (i >= 0 &&
                        i < board.BoardWidth &&
                        j >= 0 &&
                        j < board.BoardHeight &&
                        board.getCell(i, j))
                    {
                        aliveNeighbors++;
                    }
                    
                }
            }
            // Resta 1 si la celda actual (x, y) está viva
            // (porque en el loop anterior la contamos a ella misma)
            if (board.getCell(x, y))
            {
                aliveNeighbors--;
            }
            return aliveNeighbors;
        }
    }
}