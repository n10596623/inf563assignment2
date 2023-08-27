using System.Data;

namespace ifn563_object;
class program
{
        public static void Main(string[] args)
    {

        UserInterface.DisplayWelcomeMessage();
        UserInterface.DecideGameToPlay();
        int a = int.Parse(Console.ReadLine());
        Game.SelectGame(a);
        UserInterface.DecideGameMode();
        int b = int.Parse(Console.ReadLine());

        HumanPlayer firstPlayer;

         Game.CreateHumanPlayer(out firstPlayer);   
        //Game.CreateNewPlayer(b, out  HumanPlayer firstPlayer, out  Player secondPlayer);
        //Console.WriteLine(secondPlayer.ComputerPlayerName);
         //string v = ((Computerlayer)secondPlayer).ComputerPlayerName;
         //Console.WriteLine(v);

        

    
        
        // review how we draw the board
        //Board.draw(sos);
        
    }

    //method to handle type casting of the different player subclass objects
    //public static void PlayerObjectCast() 
    
    
}