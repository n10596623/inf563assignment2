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
public static void CreateHumanPlayer()
{
 Humanplayer humanplayer = new Humanplayer();
 Console.WriteLine(humanplayer);
}
public static void CreateComputerPlayer(out Computerplayer computer)
{
 computer = new Computerplayer();
 Console.WriteLine(computer);
}
public static void CreateNewPlayer(int c, out Player firstPlayer, out Player secondPlayer)
{
    
    if(c == 1)
    {
        
        //when Human Vs Human is selected we should initialize 2 HumanPlayer objects
        
         
        Console.WriteLine("Human Vs Human was selected");
        firstPlayer = new Humanplayer();
        secondPlayer = new Humanplayer();
        
    }else
    {
        //when Computer Vs Human is selected we should initialize 1 HumanPlayer object and 1 ComputerPlayer object
        
       
        Console.WriteLine("Computer Vs Human was select");
        firstPlayer = new Humanplayer();;
        secondPlayer = new Computerplayer();;
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