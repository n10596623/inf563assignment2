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
public Player(){}
public Player(string playerName, string playerType)
{
    PlayerName = playerName;
    PlayerType = playerType;
}
// We can edit this tomorrow
/*public int Move
{
    set;get;
}
//methods
public virtual int playMove()
{
    return Move;
}*/

}
 class Computerplayer : Player
{
    //data fields
    private string computerPlayerName = "Computer";
    //properties
    public string ComputerPlayerName
    {
    get { return computerPlayerName; }
    }
    public int ComputerPlayerMove
    {
     get;set;
    }
    //methods
    public override int playMove()
    {  
      return ComputerPlayerMove;
    }
     //method that selects valid move for computer to play
    public int SelectValidMove()
    {
        //we can discuss how the computer will find out which move is valid
       return ComputerPlayerMove;
    }

}
 class Humanplayer : Player
{
    //data fields
    private string HumanplayerName;

    //properties
    public string HumanPlayerName
    {
    get { return HumanplayerName; }
    set { HumanplayerName = value; }
    }
    public int HumanPlayerMove
    {
    get; set;
    }
    //methods
    public override int playMove()
    {
    return HumanPlayerMove;
    }

}