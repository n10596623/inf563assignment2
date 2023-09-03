using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace ifn563_object;
class program
{
        public static void Main(string[] args)
    {
        //declare variables
        string gameMode, gameType;
        int userInput;

        UserInterface.DecideGameMode();
        userInput = IntUserInput();
        Console.WriteLine(IsValid(userInput));
        GameMode(userInput, out gameMode);
        Console.WriteLine();

        IBoard board1= new ConnectFourBoard(7,6);
    
        board1.Display();

        /*UserInterface.DisplayWelcomeMessage();
        UserInterface.DecideGameToPlay();
        int a = int.Parse(Console.ReadLine());
        Game.SelectGame(a);
        UserInterface.DecideGameMode();
        int b = int.Parse(Console.ReadLine());*/
        

        
        //Game.CreateNewPlayer(b, out  Player firstPlayer, out  Player secondPlayer);
         //string v = ((Computerplayer)secondPlayer).ComputerPlayerName;
         //Console.WriteLine(v);


    
        
        // review how we draw the board
        //Board.draw(sos);
        
    }

    //method to capture user input
    public static int IntUserInput()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    //method that checks if input is valid
    public static bool IsValid(int userInput)
    {
        if(userInput == 1 || userInput == 2)
        {
            return true ;
        }else
        {
            return false;
        }

    }
    //method that allows user to select either Human VS Human or Computer VS Human
    public static void GameMode(int selectedGameMode , out string gameMode)
    {
        while(!IsValid(selectedGameMode))
        {
            UserInterface.InvalidInput();
            UserInterface.DecideGameMode();
            selectedGameMode = IntUserInput();
        }
        
            if(selectedGameMode == 1)
            {
                gameMode = "HVH";

            }else
            {
                gameMode = "CVH";
            }
        }
    }
    
    
    
