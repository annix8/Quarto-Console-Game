using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Board myBoard = new Board();

            while (true)
            {
                // clears the console of the previous (if any) inputs
                Console.Clear();
                // draws the board
                myBoard.DrawBoard();
                Console.Write("Choose a place: ");
                int currentPlace = int.Parse(Console.ReadLine());
                Console.Write("Choose a figure: ");
                int currentFigure = int.Parse(Console.ReadLine());

                // puts a figure on the board
                myBoard.PutFigure(currentPlace, currentFigure);

                // checks if there are any winning conditions and if any are found 
                // it stops the game
                if(myBoard.CheckGame())
                {
                    break;
                }
            
            }


        }
    }
}
