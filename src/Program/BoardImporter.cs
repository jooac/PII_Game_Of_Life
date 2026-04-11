using System;
using System.IO;

namespace Program
{
    public class BoardImporter
    {
        
        public static Board Import(string path)
        {
            string content = File.ReadAllText(path);
            string[] contentLines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            int height = contentLines.Length;
            int width = contentLines[0].TrimEnd('\r').Length;
            Board board = new Board(height, width);

            for (int y = 0; y < height; y++)
            {
                string line = contentLines[y].TrimEnd('\r');

                for (int x = 0; x < width; x++)
                {
                    board.SetCell(x,y,line[x]== '1');
                }
            }

            return board;
        }
    }
}