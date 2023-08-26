using System.Data;

namespace ifn563_object;
class program
{
        public static void Main(string[] args)
    {
        
        UserInterface.DisplayWelcomeMessage();
        UserInterface.DecideGameToPlay();
        int a=int.Parse(Console.ReadLine());
        Game.SelectGame(a);
        
        
        // review how we draw the board
        //Board.draw(sos);
        
    }
    
    
}