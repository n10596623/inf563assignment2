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
        Game.CreateNewPlayer(b);
        player1
        
        // review how we draw the board
        //Board.draw(sos);
        
    }
    
    
}