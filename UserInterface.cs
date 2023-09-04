public class UserInterface
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello there! welcome to our game.");
        Console.WriteLine("This game framework has two game: Connect Four Game, SOS Game");
        

    }
    public static void DecideGameToPlay()
    {
        Console.WriteLine("Enter 1 for SOS Game. Enter 2 for Connect Four Game.");

    }

    public static void DecidePlayerMode()
    {
        Console.WriteLine("Enter 1 for Human Vs Human or Enter 2 for Computer VS Human.");

    }
    public static void SOSUserGuild()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("SOS is the 3x3 board game. ");
        Console.WriteLine(" 'R' is redo, 'U' is Undo ");
        Console.WriteLine("enter the number as 1 3 which means raw 1 and colume 3");
        Console.WriteLine("****************************");

    }
    public static void ConnectFourUserGuild()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("ConnectFour is the 7x4 game.");
        Console.WriteLine("'R' is redo, 'U' is undo");
        Console.WriteLine("enter the number as 1 3 which means raw 1 and colume 3");
        Console.WriteLine("****************************");
    }
    public static void Displayplayer1()
    {
        Console.WriteLine("enter first player type:");
        
    }
    public static void InvalidInput()
    {
        Console.WriteLine("INVALID INPUT!!!! Please enter input as intructed");
        
    }
    public static void RequestPlayerNameInput()
    {
        Console.WriteLine("Please enter player name:");
        
    }
    public static void ShowPlayerTurn(Player player)
    {
        Console.WriteLine("{0} please play move ", player.PlayerName);
        
    }
}