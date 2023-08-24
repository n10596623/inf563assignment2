using Microsoft.VisualBasic.FileIO;

class Player
{
//data field 

private string playerName ;
private string playerType ;

//properties
public string PlayerName
{
    get {return playerName;}
    set{playerName = value;}

}
public string PlayerType
{
     get{return playerType;}
     set{playerType = value;}
}

//constructors 
//i am daniel
public Player(){}
public Player(string playerName, string playerType)
{
    PlayerName = playerName;
    PlayerType = playerType;
}



}
 class Computerplayer : Player
{


}
 class Humanplayer : Player
{


}