using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoAttempt
{
    class Board
    {
        // initialize board with empty slots
        Figure[][] positions = new Figure[4][] {
            new Figure[] {null, null, null, null },
            new Figure[] {null, null, null, null },
            new Figure[] {null, null, null, null },
            new Figure[] {null, null, null, null } };


        // initialize all of the figures
        Figure[] figures = new Figure[16]
         {
            new Figure() {height = false, color = false, hole = false , type = false },
            new Figure() {height = false, color = false, hole = false , type = false },
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } ,
            new Figure() {height = false, color = false, hole = false , type = false } 

        };

        public void putFigure(int place, int figureType)
        {
        
            int x = place / 4;
            int y = place % 4;
            if(positions[x][y] != null)
            {
                return;
            }
            else
            {
                positions[x][y] = figures[figureType];
            }
           



        }

        public bool checkGame()
        {
            // checks the rows
            for (int i = 0; i < positions.Length; i++)
            {
                Figure[] result = positions[i];
                bool checkedRows = checkAll(result[0], result[1], result[2], result[3]);
                if (checkedRows)
                {
                    Console.WriteLine("winner");
                    return true;
                    
                }

            }

            // checks the cols
            for (int i = 0; i < positions.Length; i++)
            {
                Figure[] result = new Figure[4];
                for (int j = 0; j < 4; j++)
                {
                    result[j] = positions[j][i];
                }
                bool checkedRows = checkAll(result[0], result[1], result[2], result[3]);
                if (checkedRows)
                {
                    Console.WriteLine("winner");
                    return true;
                }
            }

            // checks the main diagonal
            bool diagonalResult = checkAll(positions[0][0], positions[1][1], positions[2][2], positions[3][3]);
            if (diagonalResult)
            {
                Console.WriteLine("winner");
                return true;
            }

            // checks the secondary diagonal
            bool otherDiagonalResult = checkAll(positions[0][3], positions[1][2], positions[2][1], positions[3][0]);
            if (otherDiagonalResult)
            {
                Console.WriteLine("winner");
                return true;
            }


            return false;
        }

        public bool checkAll(Figure a, Figure b, Figure c, Figure d)
        {
            if (a == null || b == null || c == null || d == null)
            {
                return false;
            }

            if(a.height == b.height && a.height == c.height && a.height == d.height)
            {
                return true;
            }

            else if (a.color == b.color && a.color == c.color && a.color == d.color)
            {
                return true;
            }

            else if (a.hole == b.hole && a.hole == c.hole && a.hole == d.hole)
            {
                return true;
            }

            else if (a.type == b.type && a.type == c.type && a.type == d.type)
            {
                return true;
            }



            return false;
        }

        public void drawBoard()
        {
            Console.WriteLine("     |     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |", 0, 1, 2, 3);
            Console.WriteLine("_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  |", 4, 5, 6, 7);
            Console.WriteLine("_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2} |  {3} |", 8, 9, 10, 11);
            Console.WriteLine("_____|_____|_____|_____| ");
            Console.WriteLine("     |     |     |     |");
            Console.WriteLine("  {0} |  {1} |  {2} |  {3} |", 12, 13, 14, 15);
            Console.WriteLine("_____|_____|_____|_____| ");
            Console.WriteLine();

        }

    }
}
