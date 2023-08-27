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
        if (b==1)
        {
            Game.CreateHumanPlayer();
        }else{
            Game.CreateComputerPlayer(out Computerplayer computer);
            Console.WriteLine(computer.ComputerPlayerName);
        }

        
        Game.CreateNewPlayer(b, out  Player firstPlayer, out  Player secondPlayer);
         //string v = ((Computerplayer)secondPlayer).ComputerPlayerName;
         //Console.WriteLine(v);


    
        
        // review how we draw the board
        //Board.draw(sos);
        
    }

    //method to handle type casting of the different player subclass objects
    //public static void PlayerObjectCast() 
    
    
}