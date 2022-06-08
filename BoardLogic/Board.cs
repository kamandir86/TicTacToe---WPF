using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLogic
{
    public class Board
    {
        
        public int[] Grid { get; set; }
        public static string CurrentPlayer { get; set; } = X;
        private const string X = "X";
        private const string O = "O";

        // SPRAWDZIC CZY KONIECZNE

        //public Board()
        //{
        //    for (int i = 0; i < 9; i++)
        //    {
        //       // Grid[i] = 0;
        //    }

        //}


        public static void SetNextPlayer()
        {
            if (CurrentPlayer == X)
                CurrentPlayer = O;
            else
                CurrentPlayer = X;
        }

        public static bool CheckForWinner()
        {
            // check first row
            for (int i = 0; i < 3; i++)
            {
                // check if not blank
                if (true)
                {

                }
                // if 1==2 && 1==3 return true using Button tags
            }

            // the same for columns

            // the same for diagonal

            return false;
        }
    }

    
}
