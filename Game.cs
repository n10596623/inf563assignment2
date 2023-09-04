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
    private int point = 0;
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
        //declare local variables
        int row,col;
        
        

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

        //display previous board
        sosBoard.Display();
        
        //ask current player for input
        Console.WriteLine($"{currentPlayer.PlayerName}, it's your turn.");
        Console.Write("Enter row (0, 1, or 2): ");
        string rowInput = Console.ReadLine();

        //check if row input is integer 
        while (!int.TryParse(rowInput,out row) || (row < 0 || row > 2))
        {
            Console.WriteLine("Invalid row selection! Try again.");
            Console.Write("Enter row (0, 1, or 2): ");
            rowInput = Console.ReadLine();
    
        }

    

        Console.Write("Enter column (0, 1, or 2): ");
        string colInput = Console.ReadLine();

        //check if col input is integer and within range
        while (!int.TryParse(colInput,out col)||(col < 0 || col > 2 ))
        {
            Console.WriteLine("Invalid column selection! Try again.");
            Console.Write("Enter column (0, 1, or 2): ");
            colInput = Console.ReadLine();
    
        }

    
        //check if selected cell is occupied
        while(sosBoard.Board[row,col].RetrievePiece() != " ")
        {
            Console.WriteLine("Cell is occupied");
            Console.Write("Enter row (0, 1, or 2): ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Enter column (0, 1, or 2): ");
            col = int.Parse(Console.ReadLine());
        }
 

        

        //ask for piece to play
        Console.Write("Enter 'S' or 'O': ");
        string piece = Console.ReadLine().ToUpper(); // Convert to uppercase for case-insensitive check
        
        //check if piece is valid for the game
        while  (piece != "S" && piece != "O")
        {
            Console.WriteLine("Invalid symbol! Enter 'S' or 'O'.");
            piece = Console.ReadLine().ToUpper();
        }

        
    
        sosBoard.PlacePiece(row, col, piece);
        int win =AddPoint(); 
        point += win;
        sosBoard.Display();
        Console.WriteLine($"{player1.PlayerName} points are {/*add point property to player class*/point}");
        Console.WriteLine($"{player2.PlayerName} points are {/*add point property to player class*/point}");
    }
    protected override bool EndOfGame()
    {
        // edit later!!!
        return false;
    }
    
    protected override void ShowWinner()
    {
       
    }
    
    //method add point if SO connect
    public int AddPoint()
    {
    // Check for horizontal SOS sequences
    for (int row = 0; row < sosBoard.Rows; row++)
    {
        for (int col = 0; col < sosBoard.Cols - 2; col++)
        {
            if (sosBoard.Board[row, col].RetrievePiece() == "S" && sosBoard.Board[row, col + 1].RetrievePiece() == "O" && sosBoard.Board[row, col + 2].RetrievePiece() == "S")
            {
                return 1; // Horizontal SOS sequence found
            }
        }
    }

    // Check for vertical SOS sequences
    for (int row = 0; row < sosBoard.Rows - 2; row++)
    {
        for (int col = 0; col < sosBoard.Cols; col++)
        {
            if (sosBoard.Board[row, col].RetrievePiece() == "S" &&
                sosBoard.Board[row + 1, col].RetrievePiece() == "O" &&
                sosBoard.Board[row + 2, col].RetrievePiece() == "S")
            {
                return 1; // Vertical SOS sequence found
            }
        }
    }

    // Check for diagonal SOS sequences (top-left to bottom-right)
    for (int row = 0; row < sosBoard.Rows - 2; row++)
    {
        for (int col = 0; col < sosBoard.Cols - 2; col++)
        {
            if (sosBoard.Board[row, col].RetrievePiece() == "S" &&
                sosBoard.Board[row + 1, col + 1].RetrievePiece()== "O" &&
                sosBoard.Board[row + 2, col + 2].RetrievePiece() == "S")
            {
                return 1; // Diagonal SOS sequence found
            }
        }
    }

    // Check for diagonal SOS sequences (bottom-left to top-right)
    for (int row = 2; row < sosBoard.Rows; row++)
    {
        for (int col = 0; col < sosBoard.Cols - 2; col++)
        {
            if (sosBoard.Board[row, col].RetrievePiece() == "S" &&
                sosBoard.Board[row - 1, col + 1].RetrievePiece() == "O" &&
                sosBoard.Board[row - 2, col + 2].RetrievePiece() == "S")
            {
                return 1; // Diagonal SOS sequence found
            }
        }
    }

        

        return 0;
    }
}

public class ConnectFour : Game
{
    //We choose to initiate connectfour with 7*6
    ConnectFourBoard connectFourBoard = new ConnectFourBoard(7,6); 
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
    protected override void PlayMove(int player, Player player1, Player player2)
    {
        //declare variable
        int col;
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
        //display previous board
        connectFourBoard.Display();
        
        //ask current player for input
        Console.WriteLine($"{currentPlayer.PlayerName}, it's your turn.");
        //Console.Write("Enter row (0, 1, or 2): ");
        int row = connectFourBoard.Rows;
        

        Console.Write("Enter column (0, 1,2,3,4, or 5): ");
        string colInput = Console.ReadLine();

        //check if col input is integer 
        while (!int.TryParse(colInput,out col)||(col < 0 || col > 5 ))
        {
            Console.WriteLine("Invalid column selection! Try again.");
            Console.Write("Enter column (0, 1,2,3,4, or 5): ");
            colInput = Console.ReadLine();
    
        }


        

        //check if selected cell is occupied
        
        while(connectFourBoard.Board[row,col].RetrievePiece() != " ")
        {
            //check next row if occupied
            for (int i= connectFourBoard.Rows; i > 0; i--)
            {
                if(connectFourBoard.Board[row,col].RetrievePiece() == " ")
                {
                    //if empty the user can play piece



                }
            }
            Console.WriteLine("Cell is occupied");
            Console.Write(row);
        

            Console.Write("Enter column (0, 1, or 2): ");
            col = int.Parse(Console.ReadLine());
        }
 
        
       

        //ask for piece to play
        Console.Write("Enter 'S' or 'O': ");
        string piece = Console.ReadLine().ToUpper(); // Convert to uppercase for case-insensitive check
        
        //check if piece is valid for the game
        while  (piece != "S" && piece != "O")
        {
            Console.WriteLine("Invalid symbol! Enter 'S' or 'O'.");
            piece = Console.ReadLine().ToUpper();
        }

        
    
        connectFourBoard.PlacePiece(col, piece); 
        connectFourBoard.Display();


        
    }
    protected override bool EndOfGame()
    {
        //edit later
        return false;
    }
    protected override void ShowWinner()
    {
        // Check for horizontal SOS sequences

    }
}