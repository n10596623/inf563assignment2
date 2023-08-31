using System.ComponentModel;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace ifn563_object;
class program
{
        public static void Main(string[] args)
    {
        
        UserInterface.DisplayWelcomeMessage();
        //player1
        UserInterface.DecideGameMode();
        UserInterface.Displayplayer1();
        string player1 = Console.ReadLine();
        player1chose(player1, out string player1name,out int player1move);
        Console.WriteLine(player1name);
        //player2
        UserInterface.Displayplayer2();
        string player2 = Console.ReadLine();
        player2chose(player2,out string player2name,out int player2move);
        Console.WriteLine(player2name);
        //game board
        UserInterface.DecideGameToPlay();
        string a = Console.ReadLine();
        Board.SOSBoardArray(out int[] sosboard);
        Board.ConnectFourBoardArray(out int[] connectFourBoard);
        selectGame(a,sosboard,connectFourBoard,player1name,player1move,player2name,player2move);
        
        
        

        //string input = Convert.ToString(player2);
        

        

        
        //Game.CreateNewPlayer(b, out  Player firstPlayer, out  Player secondPlayer);
         //string v = ((Computerplayer)secondPlayer).ComputerPlayerName;
         //Console.WriteLine(v);


    
        
        // review how we draw the board
        //Board.draw(sos);
        
    }

    //method to handle type casting of the different player subclass objects
    
    //public static void PlayerObjectCast() 
    public static void player1chose(string c,out string player1name,out int player1move)
    {   
        
        player1name=null;
        player1move =0;
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
            player1move = (humanPlayer1).HumanPlayerMove;
            
            

        }
        else if (c == "2")
        {
           
            Game.CreateComputerPlayer1(out ComputerPlayer computer1);
            player1name = (computer1).ComputerPlayerName;
            player1move =(computer1).ComputerPlayerMove;
            
        }

    }
    public static void player2chose(string c, out string player2name,out int player2move)
    {   
        player2name=null;
        player2move =0;
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
            player2move = (humanPlayer2).HumanPlayerMove;
            
        }
        else if (c == "2")
        {
            Game.CreateComputerPlayer2(out ComputerPlayer computer2);
            player2name = (computer2).ComputerPlayerName;
            player2move =(computer2).ComputerPlayerMove;
        }

    }
    public static void selectGame(string a,int[] sosboard,int [] connectFourBoard,string player1name,int player1move,string player2name,int player2move)
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
       Game.PlaySOS(sosboard,player1name,player1move,player2name,player2move);

    }else if (a=="2")
    {
       UserInterface.ConnectFourUserGuild();
       Game.drawConnectFour(connectFourBoard);
       Game.PlayConnectFour();
    }
    
    
    }

    
    
}