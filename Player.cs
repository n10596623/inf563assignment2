using Microsoft.VisualBasic.FileIO;

public abstract class Player
{
//data field 

//properties
public bool PlayerTurn
{
    get;set;
}
//constructors 

//abstract method to be inherited
public abstract int PlayMove();

}
 class ComputerPlayer : Player
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
    public bool PlayerTurn
    {
    get;set;
    }
    
    //methods
    public override int PlayMove()
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
 class HumanPlayer : Player
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
    public bool PlayerTurn
    {
    get;set;
    }
    //methods

    //overirde parent class method.
    public override int PlayMove()
    {
    return HumanPlayerMove;
    }

}