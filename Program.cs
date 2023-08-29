using System.ComponentModel;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace ifn563_object;
class program
{
        public static void Main(string[] args)
    {
        
        UserInterface.DisplayWelcomeMessage();
        UserInterface.DecideGameToPlay();
        string a = Console.ReadLine();

        Board.SOSBoardArray(out char[] sosboard);
        Board.ConnectFourBoardArray(out int[] connectFourBoard);
        selectGame(a,sosboard,connectFourBoard);
        UserInterface.DecideGameMode();
        UserInterface.Displayplayer1();
        int player1 = int.Parse(Console.ReadLine());
       
        player1chose(player1);
        UserInterface.Displayplayer2();
        int player2 = int.Parse(Console.ReadLine());
        
        player2chose(player2);
        
        

        //string input = Convert.ToString(player2);
        

        

        
        //Game.CreateNewPlayer(b, out  Player firstPlayer, out  Player secondPlayer);
         //string v = ((Computerplayer)secondPlayer).ComputerPlayerName;
         //Console.WriteLine(v);


    
        
        // review how we draw the board
        //Board.draw(sos);
        
    }

    //method to handle type casting of the different player subclass objects
    
    //public static void PlayerObjectCast() 
    public static void player1chose(int c)
    {   
        
        if (c ==1)
        {
            
            Game.CreateHumanPlayer1(out HumanPlayer humanPlayer1);
            

        }
        else if (c == 2)
        {
           
            Game.CreateComputerPlayer1(out ComputerPlayer computer1);
            
        }
        else
        {
            Console.WriteLine("It is not valid! please enter 1 ot 2");
        }
    }
    public static void player2chose(int c)
    {   
        if (c ==1)
        {
            Game.CreateHumanPlayer2(out HumanPlayer humanPlayer2);
            
        }
        else if (c == 2)
        {
            Game.CreateComputerPlayer2(out ComputerPlayer computer2);
            
        }
        else
        {
            Console.WriteLine("It is not valid! please enter 1 ot 2");
        }
    }
    public static void selectGame(string a,char[] sosboard,int [] connectFourBoard)
    {
    while (a!="1" && a!="2"){     
     
    UserInterface.DecideGameToPlay();
    a = Console.ReadLine();
    }

    if(a == "1")
    {
    
       Game.drawSoS(sosboard);

    }else if (a=="2")
    {
       Game.drawConnectFour(connectFourBoard);
    }
    
    
    }

    
    
}