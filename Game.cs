using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Xml;

class Game
{
    //data field ////
private string gameType;
    //propoties 
public string GameType
{
    get;set;
}
    //constructure 
public Game(){}
public Game(string gameType){
    gameType = GameType;
}
    //method 
public static void SelectGame(int b)
{
    if(b == 1)
    {
        Console.WriteLine("SOS was selected");

    }else
    {
        Console.WriteLine("Connect Four was select");
    }
}
public void CreateNewGame()
{

/*Console.WriteLine("Input game name: ");
GameType = Console.ReadLine();
while(GameType != "SOS" && GameType != "ConnectFour")
{
Console.WriteLine("Input game name: ");
GameType = Console.ReadLine();
}*/

}
public static void RetriveGameDetails()
{

}
public static void DeletePlayer()
{
    
}
public static void CreateHumanPlayer1(out HumanPlayer humanPlayer1)
{

    humanPlayer1 = new HumanPlayer();
    UserInterface.Player1Name();
    humanPlayer1.HumanPlayerName=Console.ReadLine();

    
    

}
public static void CreateHumanPlayer2(out HumanPlayer humanPlayer2)
{

    humanPlayer2 = new HumanPlayer();
    UserInterface.Player2Name();
    humanPlayer2.HumanPlayerName=Console.ReadLine();
    
    

}
public static void CreateComputerPlayer1(out ComputerPlayer computer1)
{

    computer1 = new ComputerPlayer();

}
public static void CreateComputerPlayer2(out ComputerPlayer computer2)
{

    computer2 = new ComputerPlayer();

}

//Method that outputs    
/*public static void CreateGameModePlayers(int c,out HumanPlayer firstPlayer, out Player secondPlayer)
{
    
    if(c == 1)
    {
        
        //when Human Vs Human is selected we should initialize 2 HumanPlayer objects
        
         
        Console.WriteLine("Computer Vs Human was selected");
        CreateHumanPlayer(out firstPlayer);
        
        secondPlayer = new HumanPlayer();
        
    }
    else 
    {
        //when Computer Vs Human is selected we should initialize 1 HumanPlayer object and 1 ComputerPlayer object
        
       
        Console.WriteLine("Human Vs Human was select");
        firstPlayer = new HumanPlayer();
        secondPlayer = new ComputerPlayer();
    }
    //decision will be made by user before creating appropriate player objects

    
}*/

public static void drawConnectFour(int[] connectFourBoard)
{
 
 
 Console.WriteLine("        |         |        |         |        |         |        ");
 Console.WriteLine($"  {connectFourBoard[0]}     |   {connectFourBoard[1]}     |   {connectFourBoard[2]}    |   {connectFourBoard[3]}     |   {connectFourBoard[4]}    |   {connectFourBoard[5]}     |   {connectFourBoard[6]}  ");
 Console.WriteLine("--------|---------|--------|---------|--------|---------|--------");
 Console.WriteLine("        |         |        |         |        |         |        "); 
 Console.WriteLine($"  {connectFourBoard[7]}     |   {connectFourBoard[8]}     |   {connectFourBoard[9]}   |   {connectFourBoard[10]}    |   {connectFourBoard[11]}   |   {connectFourBoard[12]}    |   {connectFourBoard[13]}  ");
 Console.WriteLine("--------|---------|--------|---------|--------|---------|--------");
 Console.WriteLine("        |         |        |         |        |         |        ");
 Console.WriteLine($"  {connectFourBoard[14]}    |   {connectFourBoard[15]}    |   {connectFourBoard[16]}   |   {connectFourBoard[17]}    |   {connectFourBoard[18]}   |   {connectFourBoard[19]}    |   {connectFourBoard[20]}  ");
 Console.WriteLine("--------|---------|--------|---------|--------|---------|--------");
 Console.WriteLine("        |         |        |         |        |         |        ");
 Console.WriteLine($"  {connectFourBoard[21]}    |   {connectFourBoard[22]}    |   {connectFourBoard[23]}   |   {connectFourBoard[24]}    |   {connectFourBoard[25]}   |   {connectFourBoard[26]}    |   {connectFourBoard[27]}  ");
 Console.WriteLine("        |         |        |         |        |         |        ");
//This is just the example for the board will be 
}
static void IsMoveValid()
{

}
static void SaveGame()
{

}
static void LoadGame()
{

}
static void UndoMove()
{

}
static void RedoMove()
{

}
public static void PlaySOS(string[]sosboard,string player1name,int player1move,string player2name,int player2move)
{
    string[] player1save = new string[100];
    string[] player2save = new string[100];
    sosboard = new string[]{"1","2","3","4","5","6","7","8","9"};
   
for (int i =0;i<sosboard.Length;i++)
{
    for (int j=0; j < sosboard.Length;j++)
    {
        bool a;
        string SorO;
    if (player1name == "Computer")
    {      
           Random rnd = new Random();

           //radomize selection of S and O by computer
           string[] test1 = new string[]{"S","O"};
            int randomInt = rnd.Next(2);
            SorO = test1[randomInt];
            
           //max int will be decided later in Next() 
            player1move = rnd.Next(1,10);
            while(sosboard[player1move-1]=="S"||sosboard[player1move-1]=="O")
        {
               
               player1move = rnd.Next(1,10);

        } 
    }else{
    UserInterface.choose1SOS(player1name);
    SorO = Console.ReadLine();
    while(SorO!="S"&&SorO!="O")
    {
    UserInterface.choose1SOS(player1name);
    SorO = Console.ReadLine();
    }
    UserInterface.Player1Input(player1name);
    a=int.TryParse(Console.ReadLine(), out player1move);
    while(a==false || 0>player1move||player1move>9)
    {
      UserInterface.Player1Input(player1name);
       a= int.TryParse(Console.ReadLine(), out player1move);  
    }
    

    
    while(sosboard[player1move-1]=="S"||sosboard[player1move-1]=="O")
        {
               UserInterface.Player1Input(player1name);
               a=int.TryParse(Console.ReadLine(), out player1move);
               while(a==false || 0>player1move||player1move>9)
                {
                UserInterface.Player1Input(player1name);
                a= int.TryParse(Console.ReadLine(), out player1move);  
                }
    
        } 
    }   
    string Player1MoveString = Convert.ToString(player1move);
    

    player1save[j] = Player1MoveString;
    
    if (player1save[i]==sosboard[player1move-1])
    {
        sosboard[player1move-1]= SorO;
        
    }
    
    if (player1move==1&&player1move==2&&player1move==3&&player1move==4&&player1move==5&&player1move==6&&player1move==7&&player1move==8&&player1move==9)
    {
        
    };
    
    //sosboard=new string[]{"s","1","2","3","4","5","6","7","8"};
    Console.WriteLine("--------------------------------");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("--------------------------------");
    Board.drawSoS(sosboard);

    
    if(j==4)
    {
        break;
    }

    if (player2name == "Computer")
    {       
            Random rnd = new Random();
            string[] test1 = new string[]{"S","O"};
            int randomInt = rnd.Next(2);
            SorO = test1[randomInt];
            
           //max int will be decided later in Next() 
            player2move = rnd.Next(1,10);
            UserInterface.Player2Input(player2name);
            Console.WriteLine(player2move);
            while(sosboard[player2move-1]=="S"||sosboard[player2move-1]=="O")
        {
               
               player2move = rnd.Next(1,10);
    
        }
    }else{
    UserInterface.choose2SOS(player2name);
    SorO = Console.ReadLine();
    while(SorO!="S"&&SorO!="O")
    {
    UserInterface.choose2SOS(player2name);
    SorO = Console.ReadLine();
    }
    UserInterface.Player2Input(player2name);
    bool b=int.TryParse(Console.ReadLine(), out player2move);
    while(b==false || 0>player2move||player2move>9)
    {
      UserInterface.Player2Input(player2name);
       b= int.TryParse(Console.ReadLine(), out player2move);  
    }
    while(sosboard[player2move-1]=="S"||sosboard[player2move-1]=="O")
    {
        UserInterface.Player2Input(player2name);
        a=int.TryParse(Console.ReadLine(), out player2move);
        while(a==false || 0>player2move||player2move>9)
        {
        UserInterface.Player2Input(player2name);
        a= int.TryParse(Console.ReadLine(), out player2move);  
        }  
    } 
    }
    string Player2MoveString = Convert.ToString(player2move);
    

    player2save[j] = Player2MoveString;
    if (player2save[i]==sosboard[player2move-1])
    {
        sosboard[player2move-1]= SorO;
    }
    Board.drawSoS(sosboard);
    //Game.drawSoS();
    i=i+1;


    
}  
if(i==4)
{
    break;
}  
}
    player1save.ToList().ForEach(Console.Write);
    Console.WriteLine("//////");
    player2save.ToList().ForEach(Console.Write);
}
public static void PlayConnectFour()
{

}

}

class SosGame:Game
{
    
}

class ConnectFour:Game 
{

}