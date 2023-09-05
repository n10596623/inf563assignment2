using Microsoft.VisualBasic.FileIO;

public abstract class Player
{
//data field 
protected string playerName, playerSymbol;
protected int[] playerMoveHistory;
protected int playerPoint;
//properties
public virtual string PlayerName
{
    get;
    set;
}
public string PlayerSymbol
{
    get{return playerSymbol;}
    set{playerSymbol=value;}    
}
public int PlayerPoint
{
    get{return playerPoint;}
    set{playerPoint=value;}    
}
public int[] PlayerMoveHistory
{ 
    get { return playerMoveHistory; }
    set { playerMoveHistory = value; }

}

public bool PlayerTurn
{
    get;set;
}
//constructors 

//abstract method to be inherited


}
 class ComputerPlayer : Player
{
    //data fields
    private  string playerName = "Computer";
    //properties
    public override string PlayerName
    {
        get{return playerName;}
    }
    
    public int ComputerPlayerMove
    {
     get;set;
    }
    
    
    //methods
    //method that selects valid move for computer to play
    public int SelectValidMove(int rows , int cols)
    {
        
        //we can discuss how the computer will find out which move is valid
       return ComputerPlayerMove;
    }

}
 class HumanPlayer : Player
{
    //data fields
    private string playerName;

    //properties
    public override string PlayerName
    {
      get{return playerName;}
      set{playerName = value;}
    }
    
    //methods

    //overirde parent class method.
    
}