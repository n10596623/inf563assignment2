using System.Diagnostics;
using System.Runtime.CompilerServices;

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
public static void drawSoS(int[] sosboard)
{
 
 
 Console.WriteLine("        |         |        ");
 Console.WriteLine($"  {sosboard[0]}     |   {sosboard[1]}     |   {sosboard[2]}  ");
 Console.WriteLine("--------|---------|--------");
 Console.WriteLine("        |         |        ");
 Console.WriteLine($"  {sosboard[3]}     |   {sosboard[4]}     |   {sosboard[5]}  ");
 Console.WriteLine("--------|---------|--------");
 Console.WriteLine("        |         |        ");
 Console.WriteLine($"  {sosboard[6]}     |   {sosboard[7]}     |   {sosboard[8]}  ");
 Console.WriteLine("        |         |        ");

//This is just the example for the board will be 
}
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
public static void PlaySOS()
{

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