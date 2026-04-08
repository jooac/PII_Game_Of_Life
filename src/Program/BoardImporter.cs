using System;
using System.IO;

namespace Program
{
    public class BoardImporter
    {
        string content = File.ReadAllText(path :"src/Program/board.txt");
        public static bool[,] Import(string url)
        {
            string content = File.ReadAllText(url);
            string[] contentLines = content
                .Split('\n', StringSplitOptions.RemoveEmptyEntries);

            int width = contentLines[0].TrimEnd('\r').Length;
            int height = contentLines.Length;
            bool[,] board = new bool[width, height];

            for (int y = 0; y < height; y++)
            {
                string line = contentLines[y].TrimEnd('\r');

                for (int x = 0; x < width; x++)
                {
                    board[x, y] = line[x] == '1';
                }
            }

            return board;
        }
    }
}