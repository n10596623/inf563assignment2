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

        Board.SOSBoardArray(out int[] sosboard);
        Board.ConnectFourBoardArray(out int[] connectFourBoard);
        selectGame(a,sosboard,connectFourBoard);
        UserInterface.DecideGameMode();
        UserInterface.Displayplayer1();
        string player1 = Console.ReadLine();
        player1chose(player1, out string player1name);
        Console.WriteLine(player1name);
        UserInterface.Displayplayer2();
        string player2 = Console.ReadLine();
        
        player2chose(player2,out string player2name);
        Console.WriteLine(player2name);
        
        

        //string input = Convert.ToString(player2);
        

        

        
        //Game.CreateNewPlayer(b, out  Player firstPlayer, out  Player secondPlayer);
         //string v = ((Computerplayer)secondPlayer).ComputerPlayerName;
         //Console.WriteLine(v);


    
        
        // review how we draw the board
        //Board.draw(sos);
        
    }

    //method to handle type casting of the different player subclass objects
    
    //public static void PlayerObjectCast() 
    public static void player1chose(string c,out string player1name)
    {   
        
        player1name=null;
    while(c!="1"&&c!="2")
    {
        UserInterface.DisplayErrorInput(); 
        UserInterface.Displayplayer1();
        c = Console.ReadLine();
    }
        if (c == "1")
        {
            
            Game.CreateHumanPlayer1(out HumanPlayer humanPlayer1);
            player1name = (humanPlayer1).HumanPlayerName;
            
            

        }
        else if (c == "2")
        {
           
            Game.CreateComputerPlayer1(out ComputerPlayer computer1);
            player1name = (computer1).ComputerPlayerName;
            
        }

    }
    public static void player2chose(string c, out string player2name)
    {   
        player2name=null;
    while(c!="1"&&c!="2")
    {
        UserInterface.DisplayErrorInput(); 
        UserInterface.Displayplayer2();
        c = Console.ReadLine();
    }
        if (c =="1")
        {
            Game.CreateHumanPlayer2(out HumanPlayer humanPlayer2);
            player2name = (humanPlayer2).HumanPlayerName;
            
        }
        else if (c == "2")
        {
            Game.CreateComputerPlayer2(out ComputerPlayer computer2);
            player2name = (computer2).ComputerPlayerName;
        }

    }
    public static void selectGame(string a,int[] sosboard,int [] connectFourBoard)
    {
    while (a!="1" && a!="2"){    

    UserInterface.DisplayErrorInput();  
    UserInterface.DecideGameToPlay();
    a = Console.ReadLine();
    }

    if(a == "1")
    {
       UserInterface.SOSUserGuild();
       Game.drawSoS(sosboard);
       Game.PlaySOS();

    }else if (a=="2")
    {
       UserInterface.ConnectFourUserGuild();
       Game.drawConnectFour(connectFourBoard);
       Game.PlayConnectFour();
    }
    
    
    }

    
    
}