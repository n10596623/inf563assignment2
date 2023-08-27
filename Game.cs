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
public static void CreateHumanPlayer(out HumanPlayer humanPlayer)
{

    humanPlayer = new HumanPlayer();

}
public static void CreateComputerPlayer(out ComputerPlayer computerPlayer)
{

    computerPlayer = new ComputerPlayer();

}

//Method that outputs    
public static void CreateGameModePlayers(int c,out HumanPlayer firstPlayer, out Player secondPlayer)
{
    
    if(c == 1)
    {
        
        //when Human Vs Human is selected we should initialize 2 HumanPlayer objects
        
         
        Console.WriteLine("Computer Vs Human was selected");
        CreateHumanPlayer(out firstPlayer);
        secondPlayer = new HumanPlayer();
        
    }else
    {
        //when Computer Vs Human is selected we should initialize 1 HumanPlayer object and 1 ComputerPlayer object
        
       
        Console.WriteLine("Human Vs Human was select");
        firstPlayer = new HumanPlayer();
        secondPlayer = new ComputerPlayer();
    }
    //decision will be made by user before creating appropriate player objects

    
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
static void Play()
{

}

}

class SosGame:Game
{
    
}

class ConnectFour:Game 
{

}