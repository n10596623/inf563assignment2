using System.Diagnostics;
using System.Runtime.CompilerServices;

class game
{
    //data field 

    //propoties 

    //constructure 

    //method 
static void CreateNewGame()
{
string GameMode;
Console.WriteLine("Input game name: ");
GameMode = Console.ReadLine();
while(GameMode != "SOS" || GameMode != "ConnectFour")
{
Console.WriteLine("Input game name: ");
GameMode = Console.ReadLine();
}

}
static void RetriveGameDetails()
{

}
public static void DeletePlayer()
{
    
}
public static void CreateNewPlayer()
{
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