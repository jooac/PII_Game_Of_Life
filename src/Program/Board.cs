using System;
using System.Threading;


class Board
{
    private int boardheight;
    public int BoardHeight
    {
        get {return boardheight;} set{boardheight = value;}
    }
    private int boardwidth;
    public int BoardWidth
    {
        get {return boardwidth;} set{boardwidth = value;}
    }
    public Board(int boardheight, int boardwidth)
    {
        this.BoardWidth= boardwidth ;
        this.BoardHeight= boardheight ;
    }
    private bool[,] matriz
    {
        get {return matriz;} set{matriz= value;}
    }
}