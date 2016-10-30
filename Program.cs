﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Rebuild
{
    class Program
    {
        static void Main(string[] args)
        {
            //Draw Main Menu
            MenuHandler main = new MenuHandler();
            main.DrawMain();
            main.SelectMenuOption();
            //If A: Battleship.
            GameSession game = new GameSession();
            game.DrawGameBoard();
            //game.SetUpShips();
            //If B: Exit.
            Console.ReadKey();
        }
    }
}
