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
<<<<<<< HEAD
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
=======
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
>>>>>>> 3542fd2228cc8cda39ffb62e258fb54593b70b64
{
    
    if(c == 1)
    {
        
        //when Human Vs Human is selected we should initialize 2 HumanPlayer objects
        
         
        Console.WriteLine("Computer Vs Human was selected");
        CreateHumanPlayer(out HumanPlayer firstPlayer);
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