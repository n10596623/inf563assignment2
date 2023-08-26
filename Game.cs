using System.Diagnostics;
using System.Runtime.CompilerServices;

class Game
{
    //data field 
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
public static void CreateNewPlayer(int c, out Player player, out Player player3)
{
    if(c == 1)
    {
        //when Human Vs Human is selected we should initialize 2 HumanPlayer objects
        Player player1 = new Humanplayer();
        Player player2 = new Humanplayer(); 
        Console.WriteLine("Human Vs Human was selected");
    }else
    {
        //when Computer Vs Human is selected we should initialize 1 HumanPlayer object and 1 ComputerPlayer object
        Player player1 = new Humanplayer();
        Player computer1 = new Computerplayer();
        Console.WriteLine("Computer Vs Human was select");
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