using System.Data;
using System.Runtime;

public abstract class Game
{
    //declare abstract methods to be implemented by children
    //We template method to achieve this

    //declare variables
    private int numberOfPlayers;
    protected abstract void InitializeNewGame();
    protected abstract void PlayMove(int player);
    protected abstract bool EndOfGame();
    protected abstract void ShowWinner();
    //template method to be used by all our children classes
    public void playGame(int numberOfPlayers)
    {
        this.numberOfPlayers = numberOfPlayers;
        InitializeNewGame();
        int a = 0;
        while(!EndOfGame())
        {
            PlayMove(a);
            a = (a + 1) % numberOfPlayers; 
        }
        ShowWinner();

    }
}

public class SOSGame : Game
{
    protected override void InitializeNewGame()
    {
        //Even though our board class allows us to create specific sosboard size we decide to limit it to 3*3 for our implementation
        IBoard sosboard = new SOSBoard(3,3);

    }
    protected override void PlayMove(int player)
    {

    }
    protected override bool EndOfGame()
    {
        // edit later!!!
        return true;
    }
    protected override void ShowWinner()
    {

    }
}

public class ConnectFour : Game
{
    protected override void InitializeNewGame()
    {

    }
    protected override void PlayMove(int player)
    {

    }
    protected override bool EndOfGame()
    {
        //edit later
        return false;
    }
    protected override void ShowWinner()
    {
        
    }
}