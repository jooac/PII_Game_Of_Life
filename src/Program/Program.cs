using System;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "board.txt";
            Board board = BoardImporter.Import(path);
            Motor motor = new Motor();
            BoardPrinter printer = new BoardPrinter();
            while (true)
            {
                Console.Clear();
                printer.Print(board); //imprime generacion actual 
                board = motor.NextGeneration(board); //calcula siguiente generacion
                Thread.Sleep(2200); //pasua de 300ms 
            }
        }
    }
}
