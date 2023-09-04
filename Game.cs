using System.Data;
using System.Runtime;

public abstract class Game
{
    //declare abstract methods to be implemented by children
    //We template method to achieve this

    //declare variables
    private int numberOfPlayers;
    private Player player1, player2;
    protected abstract void InitializeNewGame(string playerMode , out Player player1, out Player player2);
    protected abstract void PlayMove(int player, Player player1, Player player2);
    
    protected abstract bool EndOfGame();
    protected abstract void ShowWinner();
    //template method to be used by all our children classes
    public void PlayGame(int numberOfPlayers, string playerMode)
    {
        this.numberOfPlayers = numberOfPlayers;
        InitializeNewGame(playerMode, out Player player1, out Player player2);
        int a = 0;
        while(!EndOfGame())
        {
            PlayMove(a,player1,player2);
            a = (a + 1) % numberOfPlayers; 
        }
        ShowWinner();

    }
}

public class SOSGame : Game
{
    //data field
    SOSBoard sosBoard = new SOSBoard(3,3);
    protected override void InitializeNewGame(string playerMode, out Player player1, out Player player2)
    {


        //create appropriate player objects
        // atleast 1 human player is choosen and name is inputted.
         player1 = new HumanPlayer();
         UserInterface.RequestPlayerNameInput();
         player1.PlayerName = Console.ReadLine();


        //select second player according to playerMode
        if(playerMode == "HVH")
        {

         player2 = new HumanPlayer();
         UserInterface.RequestPlayerNameInput();
         player2.PlayerName = Console.ReadLine();

        }else
        {
         player2 = new ComputerPlayer();
        }

    



    }
    protected override void PlayMove(int player, Player player1,Player player2)
    {
        
        

        // Determine the current player based on the player argument
        Player currentPlayer;

        if (player == 0)
        {
            currentPlayer = player1;
        }
        else
        {
            currentPlayer = player2;
        }

        Console.WriteLine($"{currentPlayer.PlayerName}, it's your turn.");
        Console.Write("Enter row (0, 1, or 2): ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter column (0, 1, or 2): ");
        int col = int.Parse(Console.ReadLine());
        
        while(sosBoard.Board[row,col].RetrievePiece() != " ")
        {
            Console.WriteLine("Cell is occupied");
            Console.Write("Enter row (0, 1, or 2): ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Enter column (0, 1, or 2): ");
            col = int.Parse(Console.ReadLine());
        }
 


        if (row < 0 || row >= 3 || col < 0 || col >= 3)
        {
            Console.WriteLine("Invalid move! Try again.");
        }
        Console.Write("Enter 'S' or 'O': ");
        string piece = Console.ReadLine().ToUpper(); // Convert to uppercase for case-insensitive check

        while  (piece != "S" && piece != "O")
        {
            Console.WriteLine("Invalid symbol! Enter 'S' or 'O'.");
            piece = Console.ReadLine().ToUpper();
        }

        // Check if the chosen cell is already occupied
       
        currentPlayer.PlayerSymbol = piece;
        string symbol = currentPlayer.PlayerSymbol;
        sosBoard.PlacePiece(row, col, symbol); 
        sosBoard.Display();
        }
    protected override bool EndOfGame()
    {
        // edit later!!!
        return false;
    }
    protected override void ShowWinner()
    {

    }
    
}

public class ConnectFour : Game
{
    protected override void InitializeNewGame(string playerMode, out Player player1, out Player player2)
    {
        //inititialize board
        //Even though our board class allows us to create specific sosboard size we decide to limit it to 7*6 for our implementation
        IBoard connectFour = new ConnectFourBoard(7,6);

        //create appropriate player objects
        player1 = new HumanPlayer();
        UserInterface.RequestPlayerNameInput();
        (player1).PlayerName = Console.ReadLine();


        //select second player according to playerMode
        if(playerMode == "HVH")
        {
            player2 = new HumanPlayer();
            UserInterface.RequestPlayerNameInput();
        }else
        {
            player2 = new ComputerPlayer();
        }
    }
    protected override void PlayMove(int player, Player player1, Player player2)
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