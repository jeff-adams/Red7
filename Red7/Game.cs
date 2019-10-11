using System;
using System.Threading;

namespace Red7
{
    public class Game
    {
        private string message;
        private Action Update {get; set;}
        private Action Draw {get; set;}

        public void Run()
        {
            Initialize();

            while(true)
            {
                Update();
                Draw();
            }
        }

        private void Initialize()
        {
            Update = MainMenu;
            Draw = MainMenuScreen;
            message = string.Empty;

            Console.Clear();
            Console.CursorVisible = false;
        }

        #region Update Methods

        private void MainMenu()
        {
            // menu selections
            //  - Host Game --> update = Dealer;
            //                  draw = GameScreen;
            //  - Join Game --> update = Client;
            //                  draw = GameScreen;
            //  - Quit --> Enviroment.Exit(0);

            // Testing input and draw loop
            if(Console.KeyAvailable)
            {
                var input = Console.ReadKey(false);
                message = $"The {input.Key} key was pressed.";
            }           
        }

        private void Dealer()
        {
            // controls the deck and "deals" cards to the other player through TCP connection
            // once cards are "dealt" --> update = Player;
        }

        private void Client()
        {
            // accepts cards from "dealer" through TCP connection
            // once cards are recieved --> update = Player;
        }

        private void Player()
        {
            // play cards and check win conditions
            // option menu selected --> update = OptionMenu;
            //                          draw = OptionMenuScreen;
        }

        private void OptionMenu()
        {
            // player can select
            // - Resume --> update = Player;
            //              draw = GameScreen;
            // - Quit --> update = MainMenu;
            //              draw = GameScreen;
        }

        #endregion

        #region Draw Methods

        private void MainMenuScreen()
        {
            // create main menu screen
            // console.write menu

            // Testing input and draw loop
            Console.SetCursorPosition(2, Console.WindowTop);
            Console.WriteLine(DateTime.Now);

            if (!string.IsNullOrEmpty(message))
            {
                Console.Write(message);
                WriteClear(Console.WindowWidth - message.Length);
                message = string.Empty;
            }
        }

        private void GameScreen()
        {
            // draws the player's hand, palette, current rule, and game info side bar
            // console.write game screen
        }

        private void OptionMenuScreen()
        {
            // draws the option menu
            // console.write option menu
        }

        private void WriteClear(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(" ");
            }
        }

        #endregion
    } 
}