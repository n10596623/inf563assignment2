using System.Diagnostics;
using System.Runtime.CompilerServices;

class game
{
    //data field 
private string gameType;
    //propoties 
public string GameType
{
    get;set;
}
    //constructure 
public game(){}
public game(string gameType){}
    //method 
public static void CreateNewGame()
{
string GameMode;
Console.WriteLine("Input game name: ");
GameMode = Console.ReadLine();
while(GameMode != "SOS" && GameMode != "ConnectFour")
{
Console.WriteLine("Input game name: ");
GameMode = Console.ReadLine();
}

}
public static void RetriveGameDetails()
{

}
public static void DeletePlayer()
{
    
}
public static void CreateNewPlayer()
{
    //decision will be made by user before creating appropriate player objects
Computerplayer computer1 = new Computerplayer{PlayerName="computer1",PlayerType="C"};
Humanplayer Human1 = new Humanplayer{PlayerName="Human",PlayerType="H"};
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

class SosGame:game
{
    
}

class ConnectFour:game 
{

}