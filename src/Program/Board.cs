using System;
using System.Threading;

namespace Program
{

    /// <summary>
    /// representa el tablero del juego.
    /// Su responsabilidad es almacenar y exponer el estado de las celdas.
    /// no contiene logica de juego (es responabilidad de motor)
    /// </summary>
 public class Board
{

    private readonly Cell[,] cells;
    
    public int BoardHeight { get; }
    public int BoardWidth { get; }
    
    // Crea un tablero vacío con el tamaño indicado.
    public Board(int boardheight, int boardwidth)
    {
        BoardHeight= boardheight ;
        BoardWidth= boardwidth ;
        cells = new Cell[BoardWidth, BoardHeight];

        for (int x = 0; x < BoardWidth; x++)
            {
                for (int y = 0; y < BoardHeight; y++)
                {
                    cells[x, y] = new Cell { State = false };
                }
            }

    }

    // Retorna el estado actual de la celda en la posición (x, y).    
    public bool getCell(int x, int y)
    {
        return cells[x, y].State;
    }

    // Asigna el estado de la celda en la posición (x, y).
    public void SetCell(int x, int y, bool isAlive)
    {
        cells[x, y].State = isAlive;
    }
}
}