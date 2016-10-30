using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_Rebuild
{
    class MenuHandler
    {
        public void DrawMain()
        {


            //Draw Main
            Console.SetWindowSize(95, 50);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("    *****************************************************************************************");
            Console.WriteLine("    **                                                                                     **");
            Console.WriteLine("    ** Battleship v.1               Programmer: M. Strong             Last Edit: 10/28/16  **");
            Console.WriteLine("    **                                                                                     **");
            Console.WriteLine("    *****************************************************************************************");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **....#####....####...######..######..##......######...####...##..##..######..#####....**");
            Console.WriteLine("    **....##..##..##..##....##......##....##......##......##......##..##....##....##..##...**");
            Console.WriteLine("    **....#####...######....##......##....##......####.....####...######....##....#####....**");
            Console.WriteLine("    **....##..##..##..##....##......##....##......##..........##..##..##....##....##.......**");
            Console.WriteLine("    **....#####...##..##....##......##....######..######...####...##..##..######..##.......**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **............................................8MN......................................**");
            Console.WriteLine("    **.............................................M.......................................**");
            Console.WriteLine("    **...........................................NMMM .....................................**");
            Console.WriteLine("    **.............................DM..........MMIMMM......................................**");
            Console.WriteLine("    **...........................  MMD.........OM,MMM......................................**");
            Console.WriteLine("    **........................... MMMM...D.....MI.MMMMMD $M................................**");
            Console.WriteLine("    **........................ M MMMMMM MMMMMMMNMMMMMMMMMMM,...............................**");
            Console.WriteLine("    **....................MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM .........M:...............,...**");
            Console.WriteLine("    **..................MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.MMO ,MMMMMMM8.MMMMNMMMM....**");
            Console.WriteLine("    **.........MMMMMMI.MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.....**");
            Console.WriteLine("    **....MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.......**");
            Console.WriteLine("    **....MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM........**");
            Console.WriteLine("    **.....MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.........**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **.................***************************************************.................**");
            Console.WriteLine("    **.................*  A. New Game           Select an Option:        *.................**");
            Console.WriteLine("    **.................*  B. Exit                                        *.................**");
            Console.WriteLine("    **.................*                                                 *.................**");
            Console.WriteLine("    **.................***************************************************.................**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    **.....................................................................................**");
            Console.WriteLine("    *****************************************************************************************");
        }

        public void SelectMenuOption()
        {
            bool bMenuOn = true;
            while (bMenuOn == true)
            {
                Console.SetCursorPosition(66, 33);
                string userMenuSelection = Console.ReadLine();

                if (userMenuSelection == "a" || userMenuSelection == "A")
                {
                    Console.SetCursorPosition(48, 35);
                    Console.WriteLine("B-SHIP SLECTED");
                    bMenuOn = false;
                }
                else if (userMenuSelection == "b" || userMenuSelection == "B")
                {
                    Console.SetCursorPosition(48, 33);
                    Console.Write("Thank you for playing.");
                    Console.SetCursorPosition(48, 34);
                    Console.Write("Press any key to exit.");
                    Console.SetCursorPosition(48, 35);
                    bMenuOn = false;
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

        }
    }
}

