using Microsoft.VisualBasic.FileIO;

abstract class Player
{
//data field 
//properties
//constructors 

//abstract method to be inherited
// public abstract int playMove();

}
 class ComputerPlayer : Player
{
    //data fields
    private string computerPlayerName = "Computer";
    private int computerPlayerMove;
    //properties
    public string ComputerPlayerName
    {
    get { return computerPlayerName; }
    }
    public int ComputerPlayerMove
    {
     get{ return computerPlayerMove;}
     set{computerPlayerMove = SelectValidMove();}
    }
    //methods
    // public override int playMove()
    // {  
    //   return ComputerPlayerMove;
    // }
     //method that selects valid move for computer to play
    public int SelectValidMove()
    {
        //we can discuss how the computer will find out which move is valid
       Random rnd = new Random();
       //max int will be decided later in Next() 
       int randomMove = rnd.Next();
       return randomMove;
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
    //methods

    //overirde parent class method.
    //  public override int playMove()
    // {
    // return HumanPlayerMove;
    // }

}