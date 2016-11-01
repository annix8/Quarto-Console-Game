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
                Console.Clear();
                //input board draw method here
                myBoard.drawBoard();
                Console.Write("Choose a place: ");
                int currentPlace = int.Parse(Console.ReadLine());
                Console.Write("Choose a figure: ");
                int currentFigure = int.Parse(Console.ReadLine());

                myBoard.putFigure(currentPlace, currentFigure);
                if(myBoard.checkGame())
                {
                    break;
                }
            
            }


        }
    }
}
