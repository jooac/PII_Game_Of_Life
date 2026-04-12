using System ;
using System.Text;

namespace Program
{
    /// <summary>
    /// Esta clase es la responsable de mostrar el tablero en pantalla.
    /// Cumple con SRP porque esa es su única responsabilidad,
    /// Y tambien con Expert porque es la mejor clase posible para imprimir 
    /// el tablero.
    /// </summary>
    public class BoardPrinter
    {
     public void Print(Board board)
        {
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < board.BoardHeight; y++)
            {
                for (int x = 0; x < board.BoardWidth; x++)
                {
                    if (board.getCell(x, y))
                        s.Append("|X|");
                    else
                        s.Append("___");
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
        }   
    }
    }
