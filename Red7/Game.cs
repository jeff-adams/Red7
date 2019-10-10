using System;

namespace Red7
{
    public class Game
    {
        private Action update;
        private Action draw;

        public void Run()
        {
            Initialize();

            while(true)
            {
                update();
                draw();
            }
        }

        private void Initialize()
        {
            update = MainMenu;
            draw = MainMenuScreen;
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

        #endregion

        #region Draw Methods

        private void MainMenuScreen()
        {
            // create main menu screen
            // console.write menu
        }

        private void OptionMenu()
        {
            // player can select 
        }

        private void GameScreen()
        {
            // draws the player's hand, palette, current rule, and game info side bar
        }

        private void OptionMenuScreen()
        {
            // draws the option menu
        }

        #endregion
    } 
}